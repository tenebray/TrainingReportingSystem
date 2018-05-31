using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using EmailComponent1;

namespace AutomatedEmailService
{
    public partial class AutomatedEmailService : ServiceBase
    {
        private Timer timer = null;
        private string ConnectionString = ConfigurationManager.ConnectionStrings["conStrDebug"].ConnectionString;
        private string SendingEmailAccount = "tenebray12@gmail.com";
        private string SendingEmailPassword = "";
        DataSet dsExpiringTraining;
        public AutomatedEmailService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("EmailSource"))
            {
                EventLog.CreateEventSource(
                    "EmailSource", "EmailLog");
            }
            eventLog1.Source = "EmailSource";
            eventLog1.Log = "EmailLog";

            timer = new Timer
            {
                Interval = GetNextTimerInterval()//(1000*60*60*24)//86400000ms // 24 hours
            };
            timer.Elapsed += new ElapsedEventHandler(this.Timer_Elapsed);
        }

        protected override void OnStart(string[] args)
        {
            timer.Start();
            eventLog1.WriteEntry("Started");
        }

        public void Timer_Elapsed(object sender, ElapsedEventArgs args)
        {
            eventLog1.WriteEntry("Monitoring the System");
            SendMail();
            timer.Interval = GetNextTimerInterval();
        }

        /// <summary>
        /// Calculaes the next interval the timer will be set at
        /// </summary>
        /// <returns>Method Returns an int</returns>
        public int GetNextTimerInterval()
        {
            DateTime now = DateTime.Now;
            DateTime nextTime = new DateTime(now.Year, now.Month, now.Day, 8,0 , 0);
            TimeSpan temp = nextTime.Subtract(now);

            int interval = (int)temp.TotalMilliseconds;
            if (interval <= 0)
                interval += (1000 * 60 * 60 * 24);
            return interval;
        }

        /// <summary>
        /// Sends an email detailing training has expired
        /// </summary>
        public void SendMail()
        {
            eventLog1.WriteEntry("Sending Email.");
            GetExpiringTrainingDataSet();

            //checks if email needs to be sent
            if (dsExpiringTraining.Tables.Count != 0)
            {
                WriteEmail email = new WriteEmail
                {
                    FromEmail = "Tenebray12@gmail.com",
                    FromName = "Colin Buchanan",
                    Subject = "ExpiringTraining",
                    SmtpServer = "smtp.gmail.com",
                    SmtpCredentials = new NetworkCredential(SendingEmailAccount, SendingEmailPassword),//pass

                    MessageBody = CreateMessageBody().ToString()
                };
                
                bool result = email.SendMail("cbuchanan592@hotmail.com", "Colin");

                //if email succeeds in sending
                if (result == true)
                {
                    LogSentEmails();
                    eventLog1.WriteEntry("Email sent.");
                }
                else
                    eventLog1.WriteEntry("Email Failed to send.");

            }
        }

        /// <summary>
        /// Gets the dataset of expiring training
        /// </summary>
        private void GetExpiringTrainingDataSet()
        {
            GetExpiringTrainingFromDB getTraining = new GetExpiringTrainingFromDB
            {
                ConnectionString = ConnectionString,
                Query = "SELECT tm.ID,hr.Forename & ' ' & hr.Surname AS Name, tm.ExpiryDate, tm.TrainingTItle, ps.Title AS Department ,tt.ExternalTraining FROM ((([tbl_Personnel-HR] AS hr LEFT JOIN [tbl_Personnel-Supervisor] AS ps ON hr.Department = ps.DeptID) LEFT JOIN tbl_TrainingMatrix AS tm ON hr.ID = tm.Employee )LEFT JOIN tbl_TrainingTitle AS tt ON tm.TrainingTItle = tt.TrainingTItle) WHERE (((tm.ExpiryDate)>=Now()) AND ((hr.ActiveStatus)<>'inactive')) ORDER BY tm.ExpiryDate, hr.Surname DESC;"
            };
            dsExpiringTraining = getTraining.GetExpiringTraining();
        }

        /// <summary>
        /// Creates the body of the email message
        /// </summary>
        /// <returns>Method returns a StringBuilder</returns>
        private StringBuilder CreateMessageBody()
        {
            StringBuilder message = new StringBuilder("<div style=\"font:12px Courier\"><pre>The following training is nearing expiration<br/><br/>");
            foreach (DataTable dt in dsExpiringTraining.Tables)
            {
                message.AppendLine("<br/>" + dt.TableName + " until expiry <br/>");
                message.AppendLine(String.Format("{0,-30} {1,-40} {2,-10}<br/><br/>", "Name", "Training Title", "Expiry Date"));
        
            foreach (DataRow dr in dt.Rows)
                {
                    message.AppendLine(String.Format("{0,-30} {1,-40} {2,-10}<br/>", dr["Name"].ToString(), dr["TrainingTitle"].ToString(), Convert.ToDateTime(dr["ExpiryDate"].ToString()).ToShortDateString()));
                }
            }
            message.AppendLine("Please make arrangements for retraining.<pre/></div>");

            return message;
        }

        /// <summary>
        /// Logs what emails that have been sent about a person for their time remaining
        /// </summary>
        private void LogSentEmails()
        {
            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                string Query2 = "SELECT * FROM tbl_SentTrainingEmails";

                OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, conn);
                DataTable dt = new DataTable();
                da2.Fill(dt);

                conn.Open();
                foreach (DataTable table in dsExpiringTraining.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO tbl_SentTrainingEmails(TrainingID,RemainingTimeFlag,DateEmailSent) VALUES ( @TrainingID, @RemainingTimeFlag,@DateEmailSent)")
                        {
                            Connection = conn
                        };
                        cmd.Parameters.Add("TrainingID", OleDbType.Numeric).Value = Convert.ToInt32(dr["ID"].ToString());
                        cmd.Parameters.Add("RemainingTimeFlag", OleDbType.VarChar).Value = table.TableName;
                        cmd.Parameters.Add("DateEmailSent", OleDbType.Date).Value = Convert.ToDateTime(dr["ExpiryDate"].ToString()).Date;
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }

        protected override void OnStop()
        {
            timer.Stop();
            eventLog1.WriteEntry("Stopped.");
        }

        protected override void OnContinue()
        {
            timer.Start();
            eventLog1.WriteEntry("Continuing.");
        }

        protected override void OnPause()
        {
            timer.Stop();
            eventLog1.WriteEntry("Paused.");
        }

        protected override void OnShutdown()
        {
            timer.Stop();
            eventLog1.WriteEntry("Shutdown.");
        }
    }
}

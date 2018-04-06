using System;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TrainingApp
{
    
    public partial class Search : Form
    {
        private string constr, query;
        private StringBuilder searchStr =  new StringBuilder("SELECT tm.TrainingTitle, tm.CertificationDate, tm.CertifiedByExperience, tm.ExpiryDate FROM[tbl_Personnel-HR] AS hr LEFT JOIN tbl_TrainingMatrix tm ON hr.ID = tm.Employee WHERE tm.Employee = @ID ");
        
        public Search(string constr)
        {
            InitializeComponent();
            this.constr = constr;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                rbActive.Checked = true;
                string query2 = "SELECT * FROM tbl_TrainingTitle ORDER BY TrainingTitle";
                
                OleDbDataAdapter da2 = new OleDbDataAdapter(query2, conn);
                DataTable dt2 = new DataTable();
                
                da2.Fill(dt2);
                cmbTraining.DataSource = dt2;
                cmbTraining.ValueMember = "TrainingTitle";
                cmbTraining.SelectedIndex = -1;

                cmbTraining.SelectedIndexChanged += new EventHandler(CmbTraining_SelectedIndexChanged);
            }
        }
        
        /// <summary>
        /// Refreshes the DataGridView
        /// </summary>
        private void UpdateView()
        {
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                OleDbCommand cmd = new OleDbCommand(searchStr.ToString(), conn);
                cmd.Parameters.Add("ID", OleDbType.Integer).Value = cmbEmployee.SelectedValue;
                cmd.Parameters.Add("TrainingTitle", OleDbType.VarChar).Value = cmbTraining.Text;

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSearch.DataSource = dt;

            }
        }

        /// <summary>
        /// Programmatically check/uncheck a radio button without triggering events  
        /// </summary>
        /// <param name="rb">RadioButton to be altered</param>
        /// <param name="TorF">True or false to enable/disable Check</param>
        private void ChangeCheck(RadioButton rb,Boolean TorF)
        {
            rb.Tag = "True";
            rb.Checked = TorF;
            rb.Tag = null;
        }

        private void CmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex != -1)
            {
                grpCertificates.Enabled = true;
                grpTraining.Enabled = true;

                ChangeCheck(rbAllTrain, true);
                ChangeCheck(rbCurrent, true);
                cmbTraining.Tag = "true";
                cmbTraining.SelectedIndex = -1;
                cmbTraining.Tag = null;
                QuerySelection();
                UpdateView();
            }
            else
            {
                grpCertificates.Enabled = false;
                grpTraining.Enabled = false;
            }
        }
        
        private void CmbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTraining.Tag == null)
            {
                QuerySelection();
                UpdateView();
            }
        }
        


        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if (rb.Tag == null)
                {
                    QuerySelection();
                    UpdateView();
                }
            }
        }

        private void RbAllTrain_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if (rb.Tag == null && cmbTraining.SelectedIndex != -1)
                {
                    QuerySelection();
                    cmbTraining.Enabled = false;
                    cmbTraining.SelectedIndex = -1;
                }
            }
        }
       
        //Loads report of the current/all training that the selected employee has 
        private void BtnCurrRep_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ReportClass displayReport = null;

            switch (btn.Name)
            {
                case "BtnAllRep":
                    {
                        displayReport = new CREmpAll();
                        break;
                    }
                case "BtnCurrRep":
                    {
                        displayReport = new CREmpCurr();
                        break;
                    }
            }
            displayReport.SetParameterValue("ID", cmbEmployee.SelectedValue);
            Reports rp = new Reports(displayReport);
            rp.Show();
        }
        
        private void RbSpecific_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if (rb.Tag == null)
                {
                    cmbTraining.Enabled = true;
                    cmbTraining.Tag = "true";
                    cmbTraining.SelectedIndex = 0;
                    cmbTraining.Tag = null;
                }
            }
        }

        private void BtnCurrRep_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ToolTip tp = new ToolTip();
            tp.Show(btn.Tag.ToString(), btn);
        }
        
        private void RbActive_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if (rbActive.Checked)
                    //All active employees
                    query = "SELECT ID,Surname+ ' ' + Forename AS Name FROM[tbl_Personnel-HR] WHERE not ActiveStatus = 'inactive' ORDER BY Surname";
                else
                    //All inactive employees
                    query = "SELECT ID,Surname+ ' ' + Forename AS Name FROM[tbl_Personnel-HR] WHERE ActiveStatus = 'inactive' ORDER BY Surname";

                using (OleDbConnection conn = new OleDbConnection(constr))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                    
                    cmbEmployee.SelectedIndexChanged -= CmbEmployee_SelectedIndexChanged;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbEmployee.DataSource = dt;
                    cmbEmployee.ValueMember = "ID";
                    cmbEmployee.DisplayMember = "Name";
                    cmbEmployee.SelectedIndex = -1;

                    ResetForm();
                   
                    cmbEmployee.SelectedIndexChanged += new EventHandler(CmbEmployee_SelectedIndexChanged);
                }
            }
        }

        /// <summary>
        /// Resets the controls on the form
        /// </summary>
        private void ResetForm()
        {
            grpCertificates.Enabled = false;
            grpTraining.Enabled = false;
            ChangeCheck(rbAllTrain, true);
            ChangeCheck(rbCurrent, true);
            cmbTraining.Tag = "true";
            cmbTraining.SelectedIndex = -1;
            cmbTraining.Tag = null;
            dgvSearch.DataSource = null;
        }

        /// <summary>
        /// Chooses which query is needed depending on radio buttons are checked
        /// </summary>
        private void QuerySelection()
        {
            searchStr.Clear();
            searchStr = new StringBuilder("SELECT tm.TrainingTitle, tm.CertificationDate, tm.CertifiedByExperience, tm.ExpiryDate FROM[tbl_Personnel-HR] AS hr LEFT JOIN tbl_TrainingMatrix tm ON hr.ID = tm.Employee WHERE tm.Employee = @ID ");
        
            if (rbAllTrain.Checked)
            {
                if (rbAll.Checked)
                    //All Training
                    searchStr.Append("ORDER BY tm.ExpiryDate,tm.TrainingTitle");
                else
                    //All current training
                    searchStr.Append("AND (tm.ExpiryDate > now() OR isNull(tm.ExpiryDate)=true ) ORDER BY tm.ExpiryDate,tm.TrainingTitle");
            }
            else
            {
                if (rbAll.Checked)
                    //All records of a specific training
                    searchStr.Append("AND tm.TrainingTitle = @TrainingTitle ORDER BY tm.ExpiryDate,tm.TrainingTitle");
                else
                    //All current records for a specific training
                    searchStr.Append("AND (tm.ExpiryDate > now() OR isNull(tm.ExpiryDate)=true ) AND tm.TrainingTitle = @TrainingTitle ORDER BY tm.ExpiryDate,tm.TrainingTitle");
            }
        }
    }
}

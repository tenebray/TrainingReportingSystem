using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace EmailComponent1
{
    public class GetExpiringTrainingFromDB
    {
        public string ConnectionString { get; set; }

        public string Query { get; set; }
        
        DataTable sentEmails = new DataTable();

        /// <summary>
        /// Returns a data set with records of expiring training that has not had an email issued
        /// </summary>
        /// <returns>Method returns dataset </returns>
        public DataSet GetExpiringTraining()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("ExpiringTraining");

            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(Query, conn);
                da.Fill(dt);

                string Query2 = "SELECT * FROM tbl_SentTrainingEmails";
                OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, conn);
                da2.FillSchema(sentEmails,SchemaType.Source);
                da2.Fill(sentEmails);

               DataTable dtCopy = dt.Copy();
                foreach (DataRow dr in dtCopy.Rows)
                {
                    var rowsToDelete = from DataRow row in dt.Rows
                                       where (row["Name"].ToString().ToLowerInvariant() == dr["Name"].ToString().ToLowerInvariant() && (row["TrainingTitle"].ToString().ToLowerInvariant() == dr["TrainingTitle"].ToString().ToLowerInvariant()) && (Convert.ToDateTime(row["ExpiryDate"].ToString()) < Convert.ToDateTime(dr["ExpiryDate"].ToString())))
                                       select row;

                    foreach (var row in rowsToDelete.ToList())
                        row.Delete();
                    dt.AcceptChanges();
                }
                dtCopy = null;
            }

            string[] tableNames = new string[3]{"Less Than One Week","Less Than One Month","Less Than Three Months" };
            DataTable[] dts = new DataTable[3];

            for (int i = 0; i < dts.Length; i++)
            {
                dts[i] = dt.Clone();
                dts[i].TableName = tableNames[i];
            }
            SortRemainingTimes(dts,dt);

            for (int i=0;i<dts.Length;i++)
            {
                if(dts[i].Rows.Count != 0)
                    ds.Tables.Add(dts[i]);
            }
            return ds;
        }

        /// <summary>
        /// Sorts the expiring training into the expiring groups
        /// </summary>
        /// <param name="dts">Array of DataTables that will hold sorted data</param>
        /// <param name="dt">Datatable that will be sorted</param>
        private void SortRemainingTimes(DataTable[] dts,DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                DateTime expiryDate = Convert.ToDateTime(dr["ExpiryDate"].ToString());
                if (expiryDate <= DateTime.Now.AddMonths(3))
                {
                    int trainingID = int.Parse(dr["ID"].ToString());
                    if (expiryDate <= DateTime.Now.AddDays(7))
                    {
                        if (CheckPreviosulySentEmails(trainingID, "Less Than One Week") == false)
                            dts[0].ImportRow(dr);
                    }
                    else if (expiryDate <= DateTime.Now.AddMonths(1))
                    {
                        if (CheckPreviosulySentEmails(trainingID, "Less Than One Month") == false)
                            dts[1].ImportRow(dr);
                    }
                    else if (expiryDate <= DateTime.Now.AddMonths(3))
                    {
                        if (CheckPreviosulySentEmails(trainingID, "Less Than Three Months") == false)
                            dts[2].ImportRow(dr);
                    }
                }
            }
        }

        /// <summary>
        /// Checks if an email has already been issued detailing that this persons training is expiring. 
        /// </summary>
        /// <param name="trainingID">The trainingID of a persons training </param>
        /// <param name="remainingTimeFlag"> The amount of time left on a persons training</param>
        /// <returns>Method returns a boolean</returns>
        private bool CheckPreviosulySentEmails(int trainingID,string remainingTimeFlag)
        {
            object[] primaryKey = new object[2];
            primaryKey[0] = trainingID;
            primaryKey[1] = remainingTimeFlag;

            if (sentEmails.Rows.Find(primaryKey) == null)
                return false;
            else
                return true;
        }
    }
}

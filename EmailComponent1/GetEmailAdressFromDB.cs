using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailComponent1
{
    class GetEmailAdressFromDB
    {
        public string ConnectionString {get;set;}

        public string StoredProcedure { get; set; }


        public DataSet GetEmailAddresses()
        {
            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(StoredProcedure, conn);
                
                da.Fill(ds);
            }
            return ds;
        }
    }
}

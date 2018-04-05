using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingApp
{
    public partial class CreateMatrix : Form
    {
        string constr,query;
        public CreateMatrix()
        {
            InitializeComponent();
            #if DEBUG
            {
                constr = ConfigurationManager.ConnectionStrings["conStrDebug"].ConnectionString;
            }
            #else
            {
                constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;          
            }
            #endif
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            DataTable dtFromGrid = new DataTable();
            dtFromGrid = dgvMatrix.DataSource as DataTable;


            MessageBox.Show(dtFromGrid.ToString());
        }

        private void CreateMatrix_Load(object sender, EventArgs e)
        {
            query = "SELECT TrainingTitle FROM[tbl_TrainingTitle] ORDER BY Trainingtitle";

            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    dgvMatrix.Columns.Add(new DataGridViewCheckBoxColumn() {Name = "col" + dr["TrainingTitle"].ToString(), HeaderText = dr["TrainingTitle"].ToString() });
                }                
            }
        }
    }
}

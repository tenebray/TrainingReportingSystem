using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Subro.Controls;

namespace TrainingApp
{
    /// <summary>
    /// Form Showing expiring training and allowing grouping 
    /// </summary>
    public partial class TrainingForm : Form
    {
        // Uses DataGridView Grouper obtained from https://www.codeproject.com/Tips/995958/DataGridViewGrouper
      
        private int underOneMonthCount, underThreeMonthCount; //Used to count the number of certificates in either 1 or 3 months categories 
        string constr;
       

        
        public TrainingForm(string constr)
        {
            InitializeComponent();
            this.constr = constr;
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                string query = "SELECT hr.Forename & ' ' & hr.Surname AS Name, tm.ExpiryDate, tm.TrainingTItle, ps.Title AS Department ,tt.ExternalTraining FROM ((([tbl_Personnel-HR] AS hr LEFT JOIN [tbl_Personnel-Supervisor] AS ps ON hr.Department = ps.DeptID) LEFT JOIN tbl_TrainingMatrix AS tm ON hr.ID = tm.Employee )LEFT JOIN tbl_TrainingTitle AS tt ON tm.TrainingTItle = tt.TrainingTItle) WHERE (((tm.ExpiryDate)>=Now()) AND ((hr.ActiveStatus)<>'inactive')) ORDER BY tm.ExpiryDate, hr.Surname DESC;";                
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);
                
                DataTable dtCopy = dt.Copy();
                foreach (DataRow dr in dtCopy.Rows)
                {
                    var rowsToDelete = from DataRow row in dt.Rows
                                       where (row["Name"].ToString().ToLowerInvariant() ==  dr["Name"].ToString().ToLowerInvariant() && (row["TrainingTitle"].ToString().ToLowerInvariant() == dr["TrainingTitle"].ToString().ToLowerInvariant()) && (Convert.ToDateTime(row["ExpiryDate"].ToString()) < Convert.ToDateTime(dr["ExpiryDate"].ToString())))
                                       select row;

                    foreach (var row in rowsToDelete.ToList())
                        row.Delete();


                    dt.AcceptChanges();
                }

                dtCopy = null;
                dgvExpire.DataSource = dt;
            };
        }

        /// <summary>
        /// Groups a datagrid view on like values within a specific column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Grouper_DisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.Summary = "contains " + e.Group.Count + " certificates";
            ColourGrid();
        }
        
        private void DgvExpire_Sorted(object sender, EventArgs e)
        {
            ColourGrid();
        }

        /// <summary>
        /// Change the background colour of the data grid view depending on time remaining
        /// </summary>
        private void ColourGrid()
        {
            underOneMonthCount = 0;
            underThreeMonthCount = 0;

            foreach (DataGridViewRow row in dgvExpire.Rows)
            {

                if (Convert.ToDateTime(row.Cells[1].Value) <= DateTime.Now.AddMonths(3))
                {
                    if (Convert.ToDateTime(row.Cells[1].Value) <= DateTime.Now.AddMonths(1))
                    {
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                        underOneMonthCount++;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Coral;
                        underThreeMonthCount++;
                    }
                }


            }
        }
        
        private void TrainingForm_Shown(object sender, EventArgs e)
        {
            ColourGrid();

            lblTotal.Text = "Total : " + dgvExpire.Rows.Count;
            lblMonth.Text = "Under one month: " + underOneMonthCount;
            lblQuarter.Text = "Under three months : " + underThreeMonthCount;
        }

        private void DataGridViewGrouper1_GroupingChanged(object sender, EventArgs e)
        {
            ColourGrid();
        }
        
    }
}

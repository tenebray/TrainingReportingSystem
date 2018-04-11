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
    /// <summary>
    /// Form for adding a new training course
    /// </summary>
    public partial class AddCourse : Form
    {
        private string constr;
        public AddCourse(string constr)
        {
            InitializeComponent();
            this.constr = constr;
        }

        private void ResetForm()
        {
            TxtTrainingTitle.Clear();
            ChBxExternal.Checked = false;
            ChbxExpires.Checked = false;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool expires = false, external = false, found = false;
            string query = "SELECT * FROM tbl_TrainingTitle";
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                OleDbCommand cmd = new OleDbCommand("INSERT INTO tbl_TrainingTitle(TrainingTitle,Expires,ExternalTraining) VALUES (@TrainingTitle,@Expires,@ExternalTraining)");
                cmd.Connection = conn;

                conn.Open();

                if (ChbxExpires.Checked)
                    expires = true;
                if (ChBxExternal.Checked)
                    external = true;

                string temp = TxtTrainingTitle.Text.Trim();
                temp = Char.ToUpper(temp[0]) + temp.Substring(1);

                DataRow[] dr = dt.Select("TrainingTitle = '" + temp + "'");
                if (dr.Length == 0)
                {
                    cmd.Parameters.Add("TrainingTitle", OleDbType.VarChar).Value = temp;
                    cmd.Parameters.Add("Expires", OleDbType.Boolean).Value = expires;
                    cmd.Parameters.Add("ExternalTraining", OleDbType.Boolean).Value = external;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New " + TxtTrainingTitle.Text + "Added");
                }
                else
                {
                    MessageBox.Show("This Training already exists");
                    found = true;
                }
            }
            if (!found)
            {
                if (MessageBox.Show("Would you like to add another record?.", "Add Training", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetForm();
                }
                else
                    this.Close();
            }
        }



        private void TxtTrainingTitle_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtTrainingTitle.Text) == true)
                btnAdd.Enabled = false;
            else
                btnAdd.Enabled = true;
        }

        /// <summary>
        /// Checks if form controls are set to default. returns true if form has changed
        /// </summary>
        /// <returns>Method returns a boolean</returns>
        private bool FormChanged()
        {
            if (String.IsNullOrWhiteSpace(TxtTrainingTitle.Text) && !ChbxExpires.Checked && !ChBxExternal.Checked)
                return false;
            else
                return true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (FormChanged() == true)
            {
                if (MessageBox.Show("Would you like to cancel the addition of this course", "Cancel Course Add", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }
    }
}

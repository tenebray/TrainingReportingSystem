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
    /// Form for adding training for an employee
    /// </summary>
    public partial class AddTraining : Form
    {
        private string constr, query;
        
        public AddTraining(string constr)
        {
            InitializeComponent();
            this.constr = constr;
        }

        private void RbCertByExp_Click(object sender, EventArgs e)
        {
            if (rbCertByExp.Checked)
                rbCertByExp.Checked = false;
            else
                rbCertByExp.Checked =true;
        }

        private void CmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex != -1)
                cmbTraining.Enabled = true;
            else
                cmbTraining.Enabled = false;
        }

        private void CmbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTraining.SelectedIndex != -1)
            {
                dtpCertDate.Enabled = true;
                btnAdd.Enabled = true;
                rbCertByExp.Enabled = true;
                dtpExpiryDate.Enabled = true;
                dtpExpiryDate.MinDate = dtpCertDate.Value;
            
            }
            else
            {
                dtpCertDate.Enabled = false;
                dtpExpiryDate.Enabled = false;
                btnAdd.Enabled = false;
                rbCertByExp.Enabled = false;
            }
        }

        /// <summary>
        /// Resets forms controls
        /// </summary>
        private void ResetForm()
        {
            cmbEmployee.SelectedIndex = -1;
            cmbTraining.SelectedIndex = -1;
            btnAdd.Enabled = false;
            dtpCertDate.Value = DateTime.Now;
            dtpExpiryDate.Value = DateTime.Now;
            rbCertByExp.Checked = false;
        }

        private void AddTraining_Load(object sender, EventArgs e)
        {
            query = "SELECT ID,Surname+ ' ' + Forename AS Name FROM[tbl_Personnel-HR] WHERE not ActiveStatus = 'inactive' ORDER BY Surname";

            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbEmployee.DataSource = dt;
                cmbEmployee.ValueMember = "ID";
                cmbEmployee.DisplayMember = "Name";
                cmbEmployee.SelectedIndex = -1;

                string query2 = "SELECT * FROM tbl_TrainingTitle ORDER BY TrainingTitle";

                OleDbDataAdapter da2 = new OleDbDataAdapter(query2, conn);
                DataTable dt2 = new DataTable();

                da2.Fill(dt2);
                cmbTraining.DataSource = dt2;
                cmbTraining.ValueMember = "ExternalTraining";
                cmbTraining.DisplayMember = "TrainingTitle";
                cmbTraining.SelectedIndex = -1;
                
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (FormChanged())
            {
                if (MessageBox.Show("Would you like to cancel the addition of this training", "Cancel Add Training", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }

        private void dtpCertDate_ValueChanged(object sender, EventArgs e)
        {
            dtpExpiryDate.MinDate = dtpCertDate.Value;
        }

        /// <summary>
        /// Checks to see if employee has a current certificate for this training
        /// </summary>
        /// <returns>Method returns a boolean</returns>
        private bool CheckTraining()
        {
            bool found = false;
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                string query = "SELECT ID,Employee, TrainingTitle,ExpiryDate FROM tbl_TrainingMatrix WHERE Employee = @Employee AND TrainingTitle = @TrainingTitle AND  @CertDate BETWEEN CertificationDate AND ExpiryDate ORDER BY ExpiryDate";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("Employee", OleDbType.Integer).Value = cmbEmployee.SelectedValue;
                cmd.Parameters.Add("TrainingTitle", OleDbType.VarChar).Value = cmbTraining.Text;
                cmd.Parameters.Add("CertDate", OleDbType.Date).Value = dtpCertDate.Value;

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                { found = true;
                    if (MessageBox.Show( cmbEmployee.Text + " currently holds this training. Expires " + Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1]["ExpiryDate"].ToString()).ToShortDateString() + ".\n Do you wish to proceed.","", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        found = false;
                }
            }
            return found;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckTraining() == false)
            {
                bool certbyExp = false;
                string query = "SELECT * FROM tbl_TrainingMatrix";
                using (OleDbConnection conn = new OleDbConnection(constr))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO tbl_Trainingmatrix(Employee,TrainingTitle,CertificationDate,CertifiedByExperience,ExpiryDate) VALUES ( @Employee, @TrainingTitle,@CertificationDate,@CertByExp,@ExpDate)");
                    cmd.Connection = conn;

                    conn.Open();

                    if (rbCertByExp.Checked)
                        certbyExp = true;

                    cmd.Parameters.Add("Employee", OleDbType.Numeric).Value = cmbEmployee.SelectedValue;
                    cmd.Parameters.Add("TrainingTitle", OleDbType.VarChar).Value = cmbTraining.Text;
                    cmd.Parameters.Add("CertificationDate", OleDbType.Date).Value = dtpCertDate.Value.Date;
                    cmd.Parameters.Add("CertByExp", OleDbType.Boolean).Value = certbyExp;
                    cmd.Parameters.Add("ExpiryDate", OleDbType.Date).Value = dtpExpiryDate.Value.Date;

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Training added for " + cmbEmployee.Text);

                
                if (MessageBox.Show("Add Training", "Would you like to add another record.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetForm();
                }
                else
                    this.Close();
            }
        }

        /// <summary>
        /// Checks if form controls are set to default. returns true if form has changed
        /// </summary>
        /// <returns>Method returns a Boolean</returns>
        private bool FormChanged()
        {
            if (cmbEmployee.SelectedIndex != -1 && cmbTraining.SelectedIndex != -1 && dtpCertDate.Value != DateTime.Now && dtpCertDate.Value != DateTime.Now && rbCertByExp.Checked)
                return true;
            else
                return false;
        }
    }
}

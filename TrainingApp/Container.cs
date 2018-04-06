using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using System.Configuration;

namespace TrainingApp
{
    /// <summary>
    /// MDI container for other forms
    /// </summary>
    public partial class Container : Form
    {
        
        private string constr;
        
            
        public Container()
        {   
            #if DEBUG
            {
                constr = ConfigurationManager.ConnectionStrings["conStrDebug"].ConnectionString;
            }
            #else
            {
                constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;          
            }
            #endif
            InitializeComponent();
        }
        
        private void Container_Load(object sender, EventArgs e)
        {
            ReportPreLoad();
            ExpiringTrainingForm();
        }

        /// <summary>
        /// Loads a blank report viewer to speed loading of later reports.
        /// </summary>
        private void ReportPreLoad()
        {
            Reports rp = new Reports()
            {
                WindowState = FormWindowState.Minimized
                ,Size = new Size(20, 20)
        };
            rp.Show();
            rp.Close();
            rp.Dispose();
        }
        
        private void MIAllExpiringTraining_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            ReportClass displayReport = null;

            switch (item.Name)
            {
                case "MIAllExpiringTraining":
                    {
                        displayReport = new CRExpiringCerts();
                        break;
                    }
                case "MIByDepartment":
                    {
                        displayReport = new CRExpiringCertsDept();
                        break;
                    }
            }

            Reports rp = new Reports(displayReport);
            rp.Show();
            
        }

        private void ExpiringTrainingForm ()
        {
            TrainingForm frm = new TrainingForm(constr)
            {
                MdiParent = this,
            };
            frm.Show();
        }

        private void TrainingMatrixReports_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            CREmpTrainMatrix report = new CREmpTrainMatrix();
            switch (item.Name)
            {
                case "MIEmployeeCurr":
                    {
                        report.SetParameterValue("ClassType", "Employee");

                        break;
                    }
                case "MISupervisionCurr":
                    {
                        report.SetParameterValue("ClassType", "Supervision");
                        break;
                    }
                case "MISeniorManageCurr":
                    {
                        report.SetParameterValue("ClassType", "Senior Management");
                        break;
                    }

            }
            Reports rp = new Reports(report)
            {
                Size = new Size(1400, 800)
            };
            rp.Show();
        }

        private void MIEmployees_Click(object sender, EventArgs e)
        {
            Search frm = new Search(constr)
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MIExpiringTraining_Click(object sender, EventArgs e)
        {
            ExpiringTrainingForm();
        }

        private void Container_MdiChildActivate(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if(f != sender && this.MdiChildren.Length > 1)
                    f.Dispose();
            }
        }

        private void NewEmployeeTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTraining frm = new AddTraining(constr)
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None
            };
            frm.Show();
            frm.FormClosed += Container_ChildFormClosed;
        }

        private void NewTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse frm = new AddCourse(constr)
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None
            };
            frm.Show();
            frm.FormClosed += Container_ChildFormClosed;
        }

        /// <summary>
        /// When child a child form closes it loads the expiring training form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Container_ChildFormClosed(object sender, EventArgs e)
        {
            ExpiringTrainingForm();
        }

    }
}

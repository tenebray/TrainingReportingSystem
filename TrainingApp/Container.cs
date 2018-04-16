using System;
using System.Drawing;
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
        private string constr, reportSource;
        
        public Container()
        {   
            #if DEBUG
            {
                constr = ConfigurationManager.ConnectionStrings["conStrDebug"].ConnectionString;
                reportSource = @"C:\Users\colin.buchanan\Documents\allPipeAccess\allpipe_dcs_be_2013.mdb";
                
                
            }
            #else
            {
                constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString; 
                reportSource = @"\\Aefp01\share\allpipe_dcs\allpipe_dcs_be_2013.mdb"; 
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
                WindowState = FormWindowState.Normal
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

            Reports rp = new Reports(displayReport, reportSource);
            rp.Show();
        }

        private void ExpiringTrainingForm ()
        {
            TrainingForm frm = new TrainingForm(constr)
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            frm.Show();
        }

        private void TrainingMatrixReports_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            CREmpTrainMatrix report = new CREmpTrainMatrix();
            switch (item.Name)
            {
                case "MISelfEmployed":
                    {
                        report.SetParameterValue("ClassType", "Self Employed");
                        break;
                    }
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
                case "MIAllStaff":
                    {
                        report.SetParameterValue("ClassType", "All");
                        break;
                    }

            }
            Reports rp = new Reports(report, reportSource)
            {
                Size = new Size(1400, 800)
            };
            rp.Show();
        }

        private void MIEmployees_Click(object sender, EventArgs e)
        {
            Search frm = new Search(constr, reportSource)
            {
                MdiParent = this,
                Dock = DockStyle.Fill
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
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
        };
            frm.Show();
            frm.FormClosed += Container_ChildFormClosed;
        }

        private void NewTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse frm = new AddCourse(constr)
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingApp
{
    /// <summary>
    /// MDI container for other forms
    /// </summary>
    public partial class Container : Form
    {
        public Container()
        {
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
            Reports rp = new Reports("")
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
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Reports rp = new Reports(item.Name.ToString());
            rp.Show();
        }

        private void ExpiringTrainingForm ()
        {
            TrainingForm frm = new TrainingForm
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void TrainingMatrixReports_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            MatrixReports rp = new MatrixReports(item.Name.ToString());
            rp.Show();
        }

        private void MIEmployees_Click(object sender, EventArgs e)
        {
            Search frm = new Search
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
            AddTraining frm = new AddTraining
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None
            };
            frm.Show();
            frm.FormClosed += Container_ChildFormClosed;
        }

        private void NewTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse frm = new AddCourse
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

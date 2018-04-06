using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TrainingApp
{
    /// <summary>
    /// Single form used for loading all crysal reports
    /// </summary>
    public partial class Reports : Form
    {
        private ReportClass DisplayReport;

        public Reports()
        {
            InitializeComponent();
        }

        public Reports(ReportClass DisplayReport)
        {
            InitializeComponent();
            this.DisplayReport = DisplayReport;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            crpvReports.ReportSource = DisplayReport;
        }
    }
}

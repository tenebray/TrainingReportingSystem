using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TrainingApp
{
    /// <summary>
    /// Single form used for loading all crystal reports
    /// </summary>
    public partial class Reports : Form
    {
        private ReportClass DisplayReport;
        private string reportSource;

        public Reports()
        {
            InitializeComponent();
        }
        
        public Reports(ReportClass DisplayReport,string reportSource)
        {
            InitializeComponent();
            this.DisplayReport = DisplayReport;
            this.reportSource = reportSource;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            if (DisplayReport != null)
            {

                DisplayReport.DataSourceConnections.Clear();
                DisplayReport.DataSourceConnections[0].SetConnection(reportSource, "", "", "");

            }
            crpvReports.ReportSource = DisplayReport;
        }
    }
}

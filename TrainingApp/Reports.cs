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
        private object Sender;//Name of the component used to open this form
        private int EmpID;//Employee ID

        public Reports(object Sender)
        {
            InitializeComponent();
            this.Sender = Sender;
        }

        public Reports(object Sender,int EmpID)
        {
            InitializeComponent();
            this.Sender = Sender;
            this.EmpID = EmpID;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
           
            switch (Sender)
            {
                case "MIAllExpiringTraining":
                    {
                        CRExpiringCerts a = new CRExpiringCerts();
                        crpvReports.ReportSource = a;
                        break;
                    }
                case "MIByDepartment":
                    {
                        CRExpiringCertsDept a = new CRExpiringCertsDept();
                        crpvReports.ReportSource = a;
                        break;
                    }
                case "BtnAllRep":
                    {
                        CREmpAll a = new CREmpAll();
                        a.SetParameterValue("ID", EmpID);
                        crpvReports.ReportSource = a;
                        
                        break;
                    }
                case "BtnCurrRep":
                    {
                        CREmpCurr a = new CREmpCurr();
                        a.SetParameterValue("ID", EmpID);
                        crpvReports.ReportSource = a;
                        break;
                    }
            }
        }
    }
}

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
    public partial class MatrixReports : Form
    {
        object Sender;
        public MatrixReports(object Sender)
        {
            InitializeComponent();
            this.Sender = Sender;
        }

        private void MatrixReports_Load(object sender, EventArgs e)
        {
            switch (Sender)
            {
                case "MIEmployeeCurr":
                    {
                        CREmpTrainMatrix a = new CREmpTrainMatrix();
                        a.SetParameterValue("ClassType", "Employee");
                        CRViewer.ReportSource = a;
                        
                        break;
                    }
                case "MISupervisionCurr":
                    {
                        CREmpTrainMatrix a = new CREmpTrainMatrix();
                        a.SetParameterValue("ClassType", "Supervision");
                        CRViewer.ReportSource = a;
                        break;
                    }
                case "MISeniorManageCurr":
                    {
                        CREmpTrainMatrix a = new CREmpTrainMatrix();
                        a.SetParameterValue("ClassType", "Senior Management");
                        CRViewer.ReportSource = a;
                        break;
                    }

            }
        }
    }
}

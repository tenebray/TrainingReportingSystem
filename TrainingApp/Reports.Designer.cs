namespace TrainingApp
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.crpvReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpvReports
            // 
            this.crpvReports.ActiveViewIndex = -1;
            this.crpvReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpvReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpvReports.Location = new System.Drawing.Point(0, 0);
            this.crpvReports.Name = "crpvReports";
            this.crpvReports.ShowCloseButton = false;
            this.crpvReports.ShowExportButton = false;
            this.crpvReports.ShowGroupTreeButton = false;
            this.crpvReports.ShowLogo = false;
            this.crpvReports.ShowParameterPanelButton = false;
            this.crpvReports.ShowRefreshButton = false;
            this.crpvReports.Size = new System.Drawing.Size(890, 562);
            this.crpvReports.TabIndex = 5;
            this.crpvReports.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 562);
            this.Controls.Add(this.crpvReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvReports;
    }
}
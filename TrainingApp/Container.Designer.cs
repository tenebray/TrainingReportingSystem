namespace TrainingApp
{
    partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expiringTrainingReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAllExpiringTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.MIByDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingMatrixReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTraingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAllStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.MIEmployeeCurr = new System.Windows.Forms.ToolStripMenuItem();
            this.MISupervisionCurr = new System.Windows.Forms.ToolStripMenuItem();
            this.MISeniorManageCurr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MIExpiringTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.MIEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MISelfEmployed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expiringTrainingReportsToolStripMenuItem,
            this.trainingMatrixReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // expiringTrainingReportsToolStripMenuItem
            // 
            this.expiringTrainingReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIAllExpiringTraining,
            this.MIByDepartment});
            this.expiringTrainingReportsToolStripMenuItem.Name = "expiringTrainingReportsToolStripMenuItem";
            this.expiringTrainingReportsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.expiringTrainingReportsToolStripMenuItem.Text = "Expiring Training Reports";
            // 
            // MIAllExpiringTraining
            // 
            this.MIAllExpiringTraining.Name = "MIAllExpiringTraining";
            this.MIAllExpiringTraining.Size = new System.Drawing.Size(180, 22);
            this.MIAllExpiringTraining.Text = "All Expiring Training";
            this.MIAllExpiringTraining.Click += new System.EventHandler(this.MIAllExpiringTraining_Click);
            // 
            // MIByDepartment
            // 
            this.MIByDepartment.Name = "MIByDepartment";
            this.MIByDepartment.Size = new System.Drawing.Size(180, 22);
            this.MIByDepartment.Text = "By Department";
            this.MIByDepartment.Click += new System.EventHandler(this.MIAllExpiringTraining_Click);
            // 
            // trainingMatrixReportsToolStripMenuItem
            // 
            this.trainingMatrixReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentTraingToolStripMenuItem});
            this.trainingMatrixReportsToolStripMenuItem.Name = "trainingMatrixReportsToolStripMenuItem";
            this.trainingMatrixReportsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.trainingMatrixReportsToolStripMenuItem.Text = "Training Matrix Reports";
            // 
            // currentTraingToolStripMenuItem
            // 
            this.currentTraingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIAllStaff,
            this.MIEmployeeCurr,
            this.MISupervisionCurr,
            this.MISeniorManageCurr,
            this.MISelfEmployed});
            this.currentTraingToolStripMenuItem.Name = "currentTraingToolStripMenuItem";
            this.currentTraingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.currentTraingToolStripMenuItem.Text = "Current Training ";
            // 
            // MIAllStaff
            // 
            this.MIAllStaff.Name = "MIAllStaff";
            this.MIAllStaff.Size = new System.Drawing.Size(181, 22);
            this.MIAllStaff.Text = "All Staff";
            this.MIAllStaff.Click += new System.EventHandler(this.TrainingMatrixReports_Click);
            // 
            // MIEmployeeCurr
            // 
            this.MIEmployeeCurr.Name = "MIEmployeeCurr";
            this.MIEmployeeCurr.Size = new System.Drawing.Size(181, 22);
            this.MIEmployeeCurr.Text = "Employee";
            this.MIEmployeeCurr.Click += new System.EventHandler(this.TrainingMatrixReports_Click);
            // 
            // MISupervisionCurr
            // 
            this.MISupervisionCurr.Name = "MISupervisionCurr";
            this.MISupervisionCurr.Size = new System.Drawing.Size(181, 22);
            this.MISupervisionCurr.Text = "Supervision";
            this.MISupervisionCurr.Click += new System.EventHandler(this.TrainingMatrixReports_Click);
            // 
            // MISeniorManageCurr
            // 
            this.MISeniorManageCurr.Name = "MISeniorManageCurr";
            this.MISeniorManageCurr.Size = new System.Drawing.Size(181, 22);
            this.MISeniorManageCurr.Text = "Senior Management";
            this.MISeniorManageCurr.Click += new System.EventHandler(this.TrainingMatrixReports_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIExpiringTraining,
            this.MIEmployees});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "View";
            // 
            // MIExpiringTraining
            // 
            this.MIExpiringTraining.Name = "MIExpiringTraining";
            this.MIExpiringTraining.Size = new System.Drawing.Size(160, 22);
            this.MIExpiringTraining.Text = "ExpiringTraining";
            this.MIExpiringTraining.Click += new System.EventHandler(this.MIExpiringTraining_Click);
            // 
            // MIEmployees
            // 
            this.MIEmployees.Name = "MIEmployees";
            this.MIEmployees.Size = new System.Drawing.Size(160, 22);
            this.MIEmployees.Text = "Employees";
            this.MIEmployees.Click += new System.EventHandler(this.MIEmployees_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTrainingToolStripMenuItem,
            this.newEmployeeTrainingToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newTrainingToolStripMenuItem
            // 
            this.newTrainingToolStripMenuItem.Name = "newTrainingToolStripMenuItem";
            this.newTrainingToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newTrainingToolStripMenuItem.Text = "New Training";
            this.newTrainingToolStripMenuItem.Click += new System.EventHandler(this.NewTrainingToolStripMenuItem_Click);
            // 
            // newEmployeeTrainingToolStripMenuItem
            // 
            this.newEmployeeTrainingToolStripMenuItem.Name = "newEmployeeTrainingToolStripMenuItem";
            this.newEmployeeTrainingToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newEmployeeTrainingToolStripMenuItem.Text = "New Training Record";
            this.newEmployeeTrainingToolStripMenuItem.Click += new System.EventHandler(this.NewEmployeeTrainingToolStripMenuItem_Click);
            // 
            // MISelfEmployed
            // 
            this.MISelfEmployed.Name = "MISelfEmployed";
            this.MISelfEmployed.Size = new System.Drawing.Size(181, 22);
            this.MISelfEmployed.Text = "Self Employed";
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Training Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Container_Load);
            this.MdiChildActivate += new System.EventHandler(this.Container_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expiringTrainingReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MIAllExpiringTraining;
        private System.Windows.Forms.ToolStripMenuItem MIByDepartment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MIExpiringTraining;
        private System.Windows.Forms.ToolStripMenuItem MIEmployees;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingMatrixReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentTraingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MIEmployeeCurr;
        private System.Windows.Forms.ToolStripMenuItem MISupervisionCurr;
        private System.Windows.Forms.ToolStripMenuItem MISeniorManageCurr;
        private System.Windows.Forms.ToolStripMenuItem MIAllStaff;
        private System.Windows.Forms.ToolStripMenuItem MISelfEmployed;
    }
}
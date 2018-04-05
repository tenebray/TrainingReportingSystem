namespace TrainingApp
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.rbCurrent = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.rbAllTrain = new System.Windows.Forms.RadioButton();
            this.grpCertificates = new System.Windows.Forms.GroupBox();
            this.BtnAllRep = new System.Windows.Forms.Button();
            this.BtnCurrRep = new System.Windows.Forms.Button();
            this.cmbTraining = new System.Windows.Forms.ComboBox();
            this.grpTraining = new System.Windows.Forms.GroupBox();
            this.rbSpecific = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.grpCertificates.SuspendLayout();
            this.grpTraining.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSearch.Location = new System.Drawing.Point(291, 12);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(699, 496);
            this.dgvSearch.TabIndex = 5;
            // 
            // rbCurrent
            // 
            this.rbCurrent.AutoSize = true;
            this.rbCurrent.Checked = true;
            this.rbCurrent.Location = new System.Drawing.Point(21, 19);
            this.rbCurrent.Name = "rbCurrent";
            this.rbCurrent.Size = new System.Drawing.Size(165, 22);
            this.rbCurrent.TabIndex = 0;
            this.rbCurrent.TabStop = true;
            this.rbCurrent.Text = "Current Certifications";
            this.rbCurrent.UseVisualStyleBackColor = true;
            this.rbCurrent.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(21, 59);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(131, 22);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Certifications";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(33, 156);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(226, 26);
            this.cmbEmployee.TabIndex = 2;
            // 
            // rbAllTrain
            // 
            this.rbAllTrain.AutoSize = true;
            this.rbAllTrain.Checked = true;
            this.rbAllTrain.Location = new System.Drawing.Point(17, 23);
            this.rbAllTrain.Name = "rbAllTrain";
            this.rbAllTrain.Size = new System.Drawing.Size(97, 22);
            this.rbAllTrain.TabIndex = 0;
            this.rbAllTrain.TabStop = true;
            this.rbAllTrain.Text = "All Training";
            this.rbAllTrain.UseVisualStyleBackColor = true;
            this.rbAllTrain.CheckedChanged += new System.EventHandler(this.RbAllTrain_CheckedChanged);
            // 
            // grpCertificates
            // 
            this.grpCertificates.Controls.Add(this.BtnAllRep);
            this.grpCertificates.Controls.Add(this.BtnCurrRep);
            this.grpCertificates.Controls.Add(this.rbAll);
            this.grpCertificates.Controls.Add(this.rbCurrent);
            this.grpCertificates.Enabled = false;
            this.grpCertificates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCertificates.Location = new System.Drawing.Point(33, 201);
            this.grpCertificates.Name = "grpCertificates";
            this.grpCertificates.Size = new System.Drawing.Size(243, 105);
            this.grpCertificates.TabIndex = 3;
            this.grpCertificates.TabStop = false;
            this.grpCertificates.Text = "Certificates";
            // 
            // BtnAllRep
            // 
            this.BtnAllRep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAllRep.BackgroundImage")));
            this.BtnAllRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAllRep.Location = new System.Drawing.Point(192, 53);
            this.BtnAllRep.Name = "BtnAllRep";
            this.BtnAllRep.Size = new System.Drawing.Size(34, 34);
            this.BtnAllRep.TabIndex = 3;
            this.BtnAllRep.Tag = "Show all certifications report";
            this.BtnAllRep.UseVisualStyleBackColor = true;
            this.BtnAllRep.Click += new System.EventHandler(this.BtnCurrRep_Click);
            this.BtnAllRep.MouseHover += new System.EventHandler(this.BtnCurrRep_MouseHover);
            // 
            // BtnCurrRep
            // 
            this.BtnCurrRep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCurrRep.BackgroundImage")));
            this.BtnCurrRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCurrRep.Location = new System.Drawing.Point(192, 13);
            this.BtnCurrRep.Name = "BtnCurrRep";
            this.BtnCurrRep.Size = new System.Drawing.Size(34, 34);
            this.BtnCurrRep.TabIndex = 1;
            this.BtnCurrRep.Tag = "Show current certifications report";
            this.BtnCurrRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCurrRep.UseVisualStyleBackColor = true;
            this.BtnCurrRep.Click += new System.EventHandler(this.BtnCurrRep_Click);
            this.BtnCurrRep.MouseHover += new System.EventHandler(this.BtnCurrRep_MouseHover);
            // 
            // cmbTraining
            // 
            this.cmbTraining.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTraining.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTraining.Enabled = false;
            this.cmbTraining.FormattingEnabled = true;
            this.cmbTraining.Location = new System.Drawing.Point(6, 80);
            this.cmbTraining.Name = "cmbTraining";
            this.cmbTraining.Size = new System.Drawing.Size(231, 26);
            this.cmbTraining.TabIndex = 3;
            // 
            // grpTraining
            // 
            this.grpTraining.Controls.Add(this.rbSpecific);
            this.grpTraining.Controls.Add(this.label2);
            this.grpTraining.Controls.Add(this.cmbTraining);
            this.grpTraining.Controls.Add(this.rbAllTrain);
            this.grpTraining.Enabled = false;
            this.grpTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTraining.Location = new System.Drawing.Point(33, 326);
            this.grpTraining.Name = "grpTraining";
            this.grpTraining.Size = new System.Drawing.Size(243, 113);
            this.grpTraining.TabIndex = 4;
            this.grpTraining.TabStop = false;
            this.grpTraining.Text = "Training";
            // 
            // rbSpecific
            // 
            this.rbSpecific.AutoSize = true;
            this.rbSpecific.Location = new System.Drawing.Point(122, 23);
            this.rbSpecific.Name = "rbSpecific";
            this.rbSpecific.Size = new System.Drawing.Size(78, 22);
            this.rbSpecific.TabIndex = 1;
            this.rbSpecific.TabStop = true;
            this.rbSpecific.Text = "Specific";
            this.rbSpecific.UseVisualStyleBackColor = true;
            this.rbSpecific.CheckedChanged += new System.EventHandler(this.RbSpecific_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course / Skill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInactive);
            this.groupBox1.Controls.Add(this.rbActive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Status";
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(122, 19);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(75, 22);
            this.rbInactive.TabIndex = 1;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.RbActive_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(21, 19);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(65, 22);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.RbActive_CheckedChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTraining);
            this.Controls.Add(this.grpCertificates);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.dgvSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training by Employee";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.grpCertificates.ResumeLayout(false);
            this.grpCertificates.PerformLayout();
            this.grpTraining.ResumeLayout(false);
            this.grpTraining.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.RadioButton rbCurrent;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbTraining;
        private System.Windows.Forms.RadioButton rbAllTrain;
        private System.Windows.Forms.GroupBox grpCertificates;
        private System.Windows.Forms.GroupBox grpTraining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button BtnAllRep;
        private System.Windows.Forms.Button BtnCurrRep;
        private System.Windows.Forms.RadioButton rbSpecific;
    }
}
namespace TrainingApp
{
    partial class AddCourse
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
            this.TxtTrainingTitle = new System.Windows.Forms.TextBox();
            this.ChBxExternal = new System.Windows.Forms.CheckBox();
            this.ChbxExpires = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTrainingTitle
            // 
            this.TxtTrainingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTrainingTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TxtTrainingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTrainingTitle.Location = new System.Drawing.Point(18, 34);
            this.TxtTrainingTitle.Name = "TxtTrainingTitle";
            this.TxtTrainingTitle.Size = new System.Drawing.Size(591, 24);
            this.TxtTrainingTitle.TabIndex = 0;
            this.TxtTrainingTitle.TextChanged += new System.EventHandler(this.TxtTrainingTitle_TextChanged);
            // 
            // ChBxExternal
            // 
            this.ChBxExternal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChBxExternal.AutoSize = true;
            this.ChBxExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBxExternal.Location = new System.Drawing.Point(18, 102);
            this.ChBxExternal.Name = "ChBxExternal";
            this.ChBxExternal.Size = new System.Drawing.Size(136, 22);
            this.ChBxExternal.TabIndex = 2;
            this.ChBxExternal.Text = "External Training";
            this.ChBxExternal.UseVisualStyleBackColor = true;
            // 
            // ChbxExpires
            // 
            this.ChbxExpires.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChbxExpires.AutoSize = true;
            this.ChbxExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbxExpires.Location = new System.Drawing.Point(18, 69);
            this.ChbxExpires.Name = "ChbxExpires";
            this.ChbxExpires.Size = new System.Drawing.Size(132, 22);
            this.ChbxExpires.TabIndex = 1;
            this.ChbxExpires.Text = "Training Expires";
            this.ChbxExpires.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Training Title";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(229, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(329, 96);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 28);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.TxtTrainingTitle);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.ChBxExternal);
            this.panel1.Controls.Add(this.ChbxExpires);
            this.panel1.Location = new System.Drawing.Point(42, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 194);
            this.panel1.TabIndex = 5;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 255);
            this.Controls.Add(this.panel1);
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTrainingTitle;
        private System.Windows.Forms.CheckBox ChBxExternal;
        private System.Windows.Forms.CheckBox ChbxExpires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}
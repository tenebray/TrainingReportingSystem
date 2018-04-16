namespace TrainingApp
{
    partial class TrainingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(this.components);
            this.dgvExpire = new System.Windows.Forms.DataGridView();
            this.dataGridViewGrouperControl1 = new Subro.Controls.DataGridViewGrouperControl();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbTotals = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpire)).BeginInit();
            this.gbTotals.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGrouper
            // 
            this.dataGridViewGrouper.DataGridView = this.dgvExpire;
            this.dataGridViewGrouper.Options = ((Subro.Controls.GroupingOptions)(resources.GetObject("dataGridViewGrouper.Options")));
            this.dataGridViewGrouper.GroupingChanged += new System.EventHandler(this.DataGridViewGrouper1_GroupingChanged);
            this.dataGridViewGrouper.DisplayGroup += new System.EventHandler<Subro.Controls.GroupDisplayEventArgs>(this.Grouper_DisplayGroup);
            // 
            // dgvExpire
            // 
            this.dgvExpire.AllowUserToAddRows = false;
            this.dgvExpire.AllowUserToDeleteRows = false;
            this.dgvExpire.AllowUserToResizeRows = false;
            this.dgvExpire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpire.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpire.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExpire.Location = new System.Drawing.Point(0, 0);
            this.dgvExpire.Name = "dgvExpire";
            this.dgvExpire.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExpire.RowHeadersVisible = false;
            this.dgvExpire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpire.Size = new System.Drawing.Size(685, 490);
            this.dgvExpire.TabIndex = 6;
            // 
            // dataGridViewGrouperControl1
            // 
            this.dataGridViewGrouperControl1.AllowDrop = true;
            this.dataGridViewGrouperControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewGrouperControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewGrouperControl1.DataGridView = this.dgvExpire;
            this.dataGridViewGrouperControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewGrouperControl1.Grouper = this.dataGridViewGrouper;
            this.dataGridViewGrouperControl1.Location = new System.Drawing.Point(32, 105);
            this.dataGridViewGrouperControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewGrouperControl1.Name = "dataGridViewGrouperControl1";
            this.dataGridViewGrouperControl1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewGrouperControl1.Size = new System.Drawing.Size(233, 24);
            this.dataGridViewGrouperControl1.TabIndex = 1;
            // 
            // lblQuarter
            // 
            this.lblQuarter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarter.Location = new System.Drawing.Point(6, 93);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(54, 18);
            this.lblQuarter.TabIndex = 2;
            this.lblQuarter.Text = "quarter";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(6, 66);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(50, 18);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "month";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "total";
            // 
            // gbTotals
            // 
            this.gbTotals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbTotals.Controls.Add(this.lblTotal);
            this.gbTotals.Controls.Add(this.lblQuarter);
            this.gbTotals.Controls.Add(this.lblMonth);
            this.gbTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotals.Location = new System.Drawing.Point(32, 15);
            this.gbTotals.Name = "gbTotals";
            this.gbTotals.Size = new System.Drawing.Size(213, 123);
            this.gbTotals.TabIndex = 5;
            this.gbTotals.TabStop = false;
            this.gbTotals.Text = "Total certificates";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewGrouperControl1);
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 260);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gbTotals);
            this.panel2.Location = new System.Drawing.Point(700, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 260);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 520);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvExpire);
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 490);
            this.panel4.TabIndex = 7;
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expiring Training";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.Shown += new System.EventHandler(this.TrainingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpire)).EndInit();
            this.gbTotals.ResumeLayout(false);
            this.gbTotals.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Subro.Controls.DataGridViewGrouper dataGridViewGrouper;
        private Subro.Controls.DataGridViewGrouperControl dataGridViewGrouperControl1;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbTotals;
        private System.Windows.Forms.DataGridView dgvExpire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}


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
            this.dgvExpire = new System.Windows.Forms.DataGridView();
            this.dataGridViewGrouper = new Subro.Controls.DataGridViewGrouper(this.components);
            this.dataGridViewGrouperControl1 = new Subro.Controls.DataGridViewGrouperControl();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbTotals = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpire)).BeginInit();
            this.gbTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExpire
            // 
            this.dgvExpire.AllowUserToAddRows = false;
            this.dgvExpire.AllowUserToDeleteRows = false;
            this.dgvExpire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpire.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExpire.Location = new System.Drawing.Point(12, 12);
            this.dgvExpire.Name = "dgvExpire";
            this.dgvExpire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpire.Size = new System.Drawing.Size(748, 496);
            this.dgvExpire.TabIndex = 0;
            this.dgvExpire.Sorted += new System.EventHandler(this.DgvExpire_Sorted);
            // 
            // dataGridViewGrouper
            // 
            this.dataGridViewGrouper.DataGridView = this.dgvExpire;
            this.dataGridViewGrouper.Options = ((Subro.Controls.GroupingOptions)(resources.GetObject("dataGridViewGrouper.Options")));
            this.dataGridViewGrouper.GroupingChanged += new System.EventHandler(this.DataGridViewGrouper1_GroupingChanged);
            this.dataGridViewGrouper.DisplayGroup += new System.EventHandler<Subro.Controls.GroupDisplayEventArgs>(this.Grouper_DisplayGroup);
            // 
            // dataGridViewGrouperControl1
            // 
            this.dataGridViewGrouperControl1.AllowDrop = true;
            this.dataGridViewGrouperControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewGrouperControl1.DataGridView = this.dgvExpire;
            this.dataGridViewGrouperControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewGrouperControl1.Grouper = this.dataGridViewGrouper;
            this.dataGridViewGrouperControl1.Location = new System.Drawing.Point(780, 92);
            this.dataGridViewGrouperControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewGrouperControl1.Name = "dataGridViewGrouperControl1";
            this.dataGridViewGrouperControl1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewGrouperControl1.Size = new System.Drawing.Size(209, 24);
            this.dataGridViewGrouperControl1.TabIndex = 1;
            // 
            // lblQuarter
            // 
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
            this.gbTotals.Controls.Add(this.lblTotal);
            this.gbTotals.Controls.Add(this.lblQuarter);
            this.gbTotals.Controls.Add(this.lblMonth);
            this.gbTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotals.Location = new System.Drawing.Point(782, 186);
            this.gbTotals.Name = "gbTotals";
            this.gbTotals.Size = new System.Drawing.Size(200, 121);
            this.gbTotals.TabIndex = 5;
            this.gbTotals.TabStop = false;
            this.gbTotals.Text = "Total certificates";
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 520);
            this.ControlBox = false;
            this.Controls.Add(this.gbTotals);
            this.Controls.Add(this.dataGridViewGrouperControl1);
            this.Controls.Add(this.dgvExpire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expiring Training";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.Shown += new System.EventHandler(this.TrainingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpire)).EndInit();
            this.gbTotals.ResumeLayout(false);
            this.gbTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpire;
        private Subro.Controls.DataGridViewGrouper dataGridViewGrouper;
        private Subro.Controls.DataGridViewGrouperControl dataGridViewGrouperControl1;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbTotals;
    }
}


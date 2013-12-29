namespace GAI.Presentation.Forms
{
    partial class FmPoliceDepartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPoliceDepartments));
            this.dgvPoliceDepartments = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliceDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoliceDepartments
            // 
            this.dgvPoliceDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliceDepartments.Location = new System.Drawing.Point(12, 12);
            this.dgvPoliceDepartments.Name = "dgvPoliceDepartments";
            this.dgvPoliceDepartments.Size = new System.Drawing.Size(144, 150);
            this.dgvPoliceDepartments.TabIndex = 0;
            this.dgvPoliceDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoliceDepartments_RowLeave);
            this.dgvPoliceDepartments.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoliceDepartments_RowLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(87, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FmPoliceDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 194);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvPoliceDepartments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmPoliceDepartments";
            this.Text = "PD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmPoliceDepartments_FormClosing);
            this.Load += new System.EventHandler(this.FmPoliceDepartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliceDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPoliceDepartments;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}
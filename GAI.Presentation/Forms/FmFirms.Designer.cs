namespace GAI.Presentation.Forms
{
    partial class FmFirms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmFirms));
            this.dgvFirms = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFirms
            // 
            this.dgvFirms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirms.Location = new System.Drawing.Point(12, 12);
            this.dgvFirms.Name = "dgvFirms";
            this.dgvFirms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFirms.Size = new System.Drawing.Size(744, 323);
            this.dgvFirms.TabIndex = 0;
            this.dgvFirms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirms_RowLeave);
            this.dgvFirms.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirms_RowLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(681, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FmFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 372);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvFirms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmFirms";
            this.Text = "Firms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmFirms_FormClosing);
            this.Load += new System.EventHandler(this.FmFirms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFirms;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;

    }
}
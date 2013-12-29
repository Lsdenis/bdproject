namespace GAI.Presentation.Forms
{
    partial class FmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMainMenu));
            this.btnTransports = new System.Windows.Forms.Button();
            this.btnOwners = new System.Windows.Forms.Button();
            this.btnOffense = new System.Windows.Forms.Button();
            this.btnPoliceDepartments = new System.Windows.Forms.Button();
            this.btnFirms = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.fmReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransports
            // 
            this.btnTransports.Location = new System.Drawing.Point(12, 12);
            this.btnTransports.Name = "btnTransports";
            this.btnTransports.Size = new System.Drawing.Size(108, 23);
            this.btnTransports.TabIndex = 0;
            this.btnTransports.Text = "Transports";
            this.btnTransports.UseVisualStyleBackColor = true;
            this.btnTransports.Click += new System.EventHandler(this.btnTransports_Click);
            // 
            // btnOwners
            // 
            this.btnOwners.Location = new System.Drawing.Point(12, 41);
            this.btnOwners.Name = "btnOwners";
            this.btnOwners.Size = new System.Drawing.Size(108, 23);
            this.btnOwners.TabIndex = 1;
            this.btnOwners.Text = "Owners";
            this.btnOwners.UseVisualStyleBackColor = true;
            this.btnOwners.Click += new System.EventHandler(this.btnOwners_Click);
            // 
            // btnOffense
            // 
            this.btnOffense.Location = new System.Drawing.Point(12, 70);
            this.btnOffense.Name = "btnOffense";
            this.btnOffense.Size = new System.Drawing.Size(108, 23);
            this.btnOffense.TabIndex = 2;
            this.btnOffense.Text = "Offense Types";
            this.btnOffense.UseVisualStyleBackColor = true;
            this.btnOffense.Click += new System.EventHandler(this.btnOffense_Click);
            // 
            // btnPoliceDepartments
            // 
            this.btnPoliceDepartments.Location = new System.Drawing.Point(13, 99);
            this.btnPoliceDepartments.Name = "btnPoliceDepartments";
            this.btnPoliceDepartments.Size = new System.Drawing.Size(108, 23);
            this.btnPoliceDepartments.TabIndex = 3;
            this.btnPoliceDepartments.Text = "Police Departments";
            this.btnPoliceDepartments.UseVisualStyleBackColor = true;
            this.btnPoliceDepartments.Click += new System.EventHandler(this.btnPoliceDepartments_Click);
            // 
            // btnFirms
            // 
            this.btnFirms.Location = new System.Drawing.Point(12, 128);
            this.btnFirms.Name = "btnFirms";
            this.btnFirms.Size = new System.Drawing.Size(108, 23);
            this.btnFirms.TabIndex = 4;
            this.btnFirms.Text = "Firms";
            this.btnFirms.UseVisualStyleBackColor = true;
            this.btnFirms.Click += new System.EventHandler(this.btnFirms_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fmReports
            // 
            this.fmReports.Location = new System.Drawing.Point(13, 157);
            this.fmReports.Name = "fmReports";
            this.fmReports.Size = new System.Drawing.Size(107, 23);
            this.fmReports.TabIndex = 6;
            this.fmReports.Text = "Reports";
            this.fmReports.UseVisualStyleBackColor = true;
            // 
            // FmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 219);
            this.Controls.Add(this.fmReports);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFirms);
            this.Controls.Add(this.btnPoliceDepartments);
            this.Controls.Add(this.btnOffense);
            this.Controls.Add(this.btnOwners);
            this.Controls.Add(this.btnTransports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmMainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransports;
        private System.Windows.Forms.Button btnOwners;
        private System.Windows.Forms.Button btnOffense;
        private System.Windows.Forms.Button btnPoliceDepartments;
        private System.Windows.Forms.Button btnFirms;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button fmReports;

    }
}
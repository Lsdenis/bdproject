using GAI.BusinessLogic.Services;

namespace GAI.Presentation.Forms
{
    partial class FmTransport
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
            this.textLicensePlates = new System.Windows.Forms.TextBox();
            this.textBrandModel = new System.Windows.Forms.TextBox();
            this.textCarcass = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.textMaxWeight = new System.Windows.Forms.TextBox();
            this.rtextNotes = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblLicensePlates = new System.Windows.Forms.Label();
            this.lblBrandModel = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCarcass = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMaxWeight = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbPoliceDepartment = new System.Windows.Forms.ComboBox();
            this.lblPoliceDepartment = new System.Windows.Forms.Label();
            this.textColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textLicensePlates
            // 
            this.textLicensePlates.Location = new System.Drawing.Point(116, 12);
            this.textLicensePlates.Name = "textLicensePlates";
            this.textLicensePlates.Size = new System.Drawing.Size(118, 20);
            this.textLicensePlates.TabIndex = 0;
            // 
            // textBrandModel
            // 
            this.textBrandModel.Location = new System.Drawing.Point(116, 38);
            this.textBrandModel.Name = "textBrandModel";
            this.textBrandModel.Size = new System.Drawing.Size(118, 20);
            this.textBrandModel.TabIndex = 1;
            // 
            // textCarcass
            // 
            this.textCarcass.Location = new System.Drawing.Point(116, 93);
            this.textCarcass.Name = "textCarcass";
            this.textCarcass.Size = new System.Drawing.Size(118, 20);
            this.textCarcass.TabIndex = 2;
            this.textCarcass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(116, 119);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(118, 20);
            this.textType.TabIndex = 3;
            // 
            // textMaxWeight
            // 
            this.textMaxWeight.Location = new System.Drawing.Point(116, 145);
            this.textMaxWeight.Name = "textMaxWeight";
            this.textMaxWeight.Size = new System.Drawing.Size(118, 20);
            this.textMaxWeight.TabIndex = 4;
            this.textMaxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // rtextNotes
            // 
            this.rtextNotes.Location = new System.Drawing.Point(56, 171);
            this.rtextNotes.Name = "rtextNotes";
            this.rtextNotes.Size = new System.Drawing.Size(178, 66);
            this.rtextNotes.TabIndex = 5;
            this.rtextNotes.Text = "";
            // 
            // lblLicensePlates
            // 
            this.lblLicensePlates.AutoSize = true;
            this.lblLicensePlates.Location = new System.Drawing.Point(12, 15);
            this.lblLicensePlates.Name = "lblLicensePlates";
            this.lblLicensePlates.Size = new System.Drawing.Size(79, 13);
            this.lblLicensePlates.TabIndex = 7;
            this.lblLicensePlates.Text = "License Plates:";
            // 
            // lblBrandModel
            // 
            this.lblBrandModel.AutoSize = true;
            this.lblBrandModel.Location = new System.Drawing.Point(12, 41);
            this.lblBrandModel.Name = "lblBrandModel";
            this.lblBrandModel.Size = new System.Drawing.Size(70, 13);
            this.lblBrandModel.TabIndex = 8;
            this.lblBrandModel.Text = "Brand Model:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 69);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color:";
            // 
            // lblCarcass
            // 
            this.lblCarcass.AutoSize = true;
            this.lblCarcass.Location = new System.Drawing.Point(12, 96);
            this.lblCarcass.Name = "lblCarcass";
            this.lblCarcass.Size = new System.Drawing.Size(48, 13);
            this.lblCarcass.TabIndex = 10;
            this.lblCarcass.Text = "Carcass:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 122);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // lblMaxWeight
            // 
            this.lblMaxWeight.AutoSize = true;
            this.lblMaxWeight.Location = new System.Drawing.Point(12, 148);
            this.lblMaxWeight.Name = "lblMaxWeight";
            this.lblMaxWeight.Size = new System.Drawing.Size(88, 13);
            this.lblMaxWeight.TabIndex = 12;
            this.lblMaxWeight.Text = "Max Weight (kg):";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 174);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notes:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 270);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbPoliceDepartment
            // 
            this.cbPoliceDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliceDepartment.FormattingEnabled = true;
            this.cbPoliceDepartment.Location = new System.Drawing.Point(116, 243);
            this.cbPoliceDepartment.Name = "cbPoliceDepartment";
            this.cbPoliceDepartment.Size = new System.Drawing.Size(118, 21);
            this.cbPoliceDepartment.TabIndex = 16;
            // 
            // lblPoliceDepartment
            // 
            this.lblPoliceDepartment.Location = new System.Drawing.Point(12, 246);
            this.lblPoliceDepartment.Name = "lblPoliceDepartment";
            this.lblPoliceDepartment.Size = new System.Drawing.Size(98, 18);
            this.lblPoliceDepartment.TabIndex = 17;
            this.lblPoliceDepartment.Text = "Police Department:";
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(116, 66);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(118, 20);
            this.textColor.TabIndex = 18;
            // 
            // FmTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 301);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.lblPoliceDepartment);
            this.Controls.Add(this.cbPoliceDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblMaxWeight);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCarcass);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblBrandModel);
            this.Controls.Add(this.lblLicensePlates);
            this.Controls.Add(this.rtextNotes);
            this.Controls.Add(this.textMaxWeight);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textCarcass);
            this.Controls.Add(this.textBrandModel);
            this.Controls.Add(this.textLicensePlates);
            this.Name = "FmTransport";
            this.Text = "FmTransport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLicensePlates;
        private System.Windows.Forms.TextBox textBrandModel;
        private System.Windows.Forms.TextBox textCarcass;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textMaxWeight;
        private System.Windows.Forms.RichTextBox rtextNotes;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblLicensePlates;
        private System.Windows.Forms.Label lblBrandModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCarcass;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMaxWeight;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbPoliceDepartment;
        private System.Windows.Forms.Label lblPoliceDepartment;
        private System.Windows.Forms.TextBox textColor;
    }
}
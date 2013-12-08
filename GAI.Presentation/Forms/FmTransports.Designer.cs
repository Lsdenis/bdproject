namespace GAI.Presentation.Forms
{
    partial class FmTransports
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
            this.lvTransports = new System.Windows.Forms.ListView();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.License_Plates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand_Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Carcass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max_Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilStatus = new System.Windows.Forms.ImageList(this.components);
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTransports
            // 
            this.lvTransports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Status,
            this.License_Plates,
            this.Brand_Model,
            this.Color,
            this.Carcass,
            this.Type,
            this.Max_Weight,
            this.Notes});
            this.lvTransports.FullRowSelect = true;
            this.lvTransports.Location = new System.Drawing.Point(12, 33);
            this.lvTransports.Name = "lvTransports";
            this.lvTransports.Size = new System.Drawing.Size(695, 355);
            this.lvTransports.TabIndex = 0;
            this.lvTransports.UseCompatibleStateImageBehavior = false;
            this.lvTransports.View = System.Windows.Forms.View.Details;
            this.lvTransports.DoubleClick += new System.EventHandler(this.lvTransports_DoubleClick);
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 42;
            // 
            // License_Plates
            // 
            this.License_Plates.Text = "License Plates";
            this.License_Plates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.License_Plates.Width = 81;
            // 
            // Brand_Model
            // 
            this.Brand_Model.Text = "Brand Model";
            this.Brand_Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Brand_Model.Width = 72;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Color.Width = 45;
            // 
            // Carcass
            // 
            this.Carcass.Text = "Carcass";
            this.Carcass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Carcass.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Max_Weight
            // 
            this.Max_Weight.Text = "Max Weight (kg)";
            this.Max_Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Max_Weight.Width = 90;
            // 
            // Notes
            // 
            this.Notes.Text = "Notes";
            this.Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Notes.Width = 200;
            // 
            // ilStatus
            // 
            this.ilStatus.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilStatus.ImageSize = new System.Drawing.Size(16, 16);
            this.ilStatus.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "Normal",
            "Problem",
            "Deleted"});
            this.cbStatus.Location = new System.Drawing.Point(60, 6);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(128, 21);
            this.cbStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(399, 6);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(100, 20);
            this.textSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(505, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "License_Plates",
            "Brand_Model",
            "Color",
            "Carcass",
            "Type",
            "Max Weight (kg)"});
            this.cbSearch.Location = new System.Drawing.Point(586, 5);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(713, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(194, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmTransports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 402);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lvTransports);
            this.Name = "FmTransports";
            this.Text = "FmTransports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTransports;
        private System.Windows.Forms.ImageList ilStatus;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader License_Plates;
        private System.Windows.Forms.ColumnHeader Brand_Model;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Carcass;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Max_Weight;
        private System.Windows.Forms.ColumnHeader Notes;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
    }
}
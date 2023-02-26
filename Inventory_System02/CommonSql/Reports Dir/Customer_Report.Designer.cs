﻿
namespace Inventory_System02.Reports_Dir
{
    partial class Customer_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Report));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_date_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Personnel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtg_PreviewPage = new System.Windows.Forms.DataGridView();
            this.grp_filters = new System.Windows.Forms.GroupBox();
            this.chk_Type = new System.Windows.Forms.CheckBox();
            this.chk_Hire_Date = new System.Windows.Forms.CheckBox();
            this.chk_Address = new System.Windows.Forms.CheckBox();
            this.chk_Phone = new System.Windows.Forms.CheckBox();
            this.chk_LN = new System.Windows.Forms.CheckBox();
            this.chk_FN = new System.Windows.Forms.CheckBox();
            this.chk_Cust_ID = new System.Windows.Forms.CheckBox();
            this.chk_Select_All = new System.Windows.Forms.CheckBox();
            this.chk_Unselect = new System.Windows.Forms.CheckBox();
            this.btn_Print_Preview = new System.Windows.Forms.Button();
            this.btn_Batch = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).BeginInit();
            this.grp_filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 365);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtp_date_from);
            this.tabPage1.Controls.Add(this.dtp_date_to);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbl_Personnel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtg_PreviewPage);
            this.tabPage1.Controls.Add(this.grp_filters);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(216, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "to";
            // 
            // dtp_date_from
            // 
            this.dtp_date_from.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_from.CustomFormat = "yyyy-MM-dd";
            this.dtp_date_from.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_from.Location = new System.Drawing.Point(93, 9);
            this.dtp_date_from.Name = "dtp_date_from";
            this.dtp_date_from.Size = new System.Drawing.Size(117, 22);
            this.dtp_date_from.TabIndex = 45;
            this.dtp_date_from.ValueChanged += new System.EventHandler(this.dtp_date_from_ValueChanged);
            // 
            // dtp_date_to
            // 
            this.dtp_date_to.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_to.CustomFormat = "yyyy-MM-dd";
            this.dtp_date_to.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_to.Location = new System.Drawing.Point(239, 9);
            this.dtp_date_to.Name = "dtp_date_to";
            this.dtp_date_to.Size = new System.Drawing.Size(117, 22);
            this.dtp_date_to.TabIndex = 44;
            this.dtp_date_to.ValueChanged += new System.EventHandler(this.dtp_date_to_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Report Date";
            // 
            // lbl_Personnel
            // 
            this.lbl_Personnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Personnel.AutoSize = true;
            this.lbl_Personnel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Personnel.Location = new System.Drawing.Point(143, 226);
            this.lbl_Personnel.Name = "lbl_Personnel";
            this.lbl_Personnel.Size = new System.Drawing.Size(0, 21);
            this.lbl_Personnel.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Customer/s:";
            // 
            // dtg_PreviewPage
            // 
            this.dtg_PreviewPage.AllowUserToAddRows = false;
            this.dtg_PreviewPage.AllowUserToDeleteRows = false;
            this.dtg_PreviewPage.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_PreviewPage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_PreviewPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_PreviewPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_PreviewPage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_PreviewPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PreviewPage.Location = new System.Drawing.Point(8, 37);
            this.dtg_PreviewPage.Name = "dtg_PreviewPage";
            this.dtg_PreviewPage.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_PreviewPage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_PreviewPage.Size = new System.Drawing.Size(725, 177);
            this.dtg_PreviewPage.TabIndex = 21;
            // 
            // grp_filters
            // 
            this.grp_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_filters.Controls.Add(this.chk_Type);
            this.grp_filters.Controls.Add(this.chk_Hire_Date);
            this.grp_filters.Controls.Add(this.chk_Address);
            this.grp_filters.Controls.Add(this.chk_Phone);
            this.grp_filters.Controls.Add(this.chk_LN);
            this.grp_filters.Controls.Add(this.chk_FN);
            this.grp_filters.Controls.Add(this.chk_Cust_ID);
            this.grp_filters.Location = new System.Drawing.Point(270, 220);
            this.grp_filters.Name = "grp_filters";
            this.grp_filters.Size = new System.Drawing.Size(457, 85);
            this.grp_filters.TabIndex = 20;
            this.grp_filters.TabStop = false;
            this.grp_filters.Text = "Data Fields";
            // 
            // chk_Type
            // 
            this.chk_Type.AutoSize = true;
            this.chk_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Type.Location = new System.Drawing.Point(387, 22);
            this.chk_Type.Name = "chk_Type";
            this.chk_Type.Size = new System.Drawing.Size(51, 19);
            this.chk_Type.TabIndex = 29;
            this.chk_Type.Text = "Type";
            this.chk_Type.UseVisualStyleBackColor = true;
            // 
            // chk_Hire_Date
            // 
            this.chk_Hire_Date.AutoSize = true;
            this.chk_Hire_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Hire_Date.Location = new System.Drawing.Point(17, 22);
            this.chk_Hire_Date.Name = "chk_Hire_Date";
            this.chk_Hire_Date.Size = new System.Drawing.Size(81, 19);
            this.chk_Hire_Date.TabIndex = 28;
            this.chk_Hire_Date.Text = "Entry Date";
            this.chk_Hire_Date.UseVisualStyleBackColor = true;
            // 
            // chk_Address
            // 
            this.chk_Address.AutoSize = true;
            this.chk_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Address.Location = new System.Drawing.Point(270, 49);
            this.chk_Address.Name = "chk_Address";
            this.chk_Address.Size = new System.Drawing.Size(68, 19);
            this.chk_Address.TabIndex = 27;
            this.chk_Address.Text = "Address";
            this.chk_Address.UseVisualStyleBackColor = true;
            // 
            // chk_Phone
            // 
            this.chk_Phone.AutoSize = true;
            this.chk_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Phone.Location = new System.Drawing.Point(270, 22);
            this.chk_Phone.Name = "chk_Phone";
            this.chk_Phone.Size = new System.Drawing.Size(60, 19);
            this.chk_Phone.TabIndex = 15;
            this.chk_Phone.Text = "Phone";
            this.chk_Phone.UseVisualStyleBackColor = true;
            // 
            // chk_LN
            // 
            this.chk_LN.AutoSize = true;
            this.chk_LN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_LN.Location = new System.Drawing.Point(146, 22);
            this.chk_LN.Name = "chk_LN";
            this.chk_LN.Size = new System.Drawing.Size(82, 19);
            this.chk_LN.TabIndex = 14;
            this.chk_LN.Text = "Last Name";
            this.chk_LN.UseVisualStyleBackColor = true;
            // 
            // chk_FN
            // 
            this.chk_FN.AutoSize = true;
            this.chk_FN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_FN.Location = new System.Drawing.Point(146, 49);
            this.chk_FN.Name = "chk_FN";
            this.chk_FN.Size = new System.Drawing.Size(83, 19);
            this.chk_FN.TabIndex = 13;
            this.chk_FN.Text = "First Name";
            this.chk_FN.UseVisualStyleBackColor = true;
            // 
            // chk_Cust_ID
            // 
            this.chk_Cust_ID.AutoSize = true;
            this.chk_Cust_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Cust_ID.Location = new System.Drawing.Point(17, 49);
            this.chk_Cust_ID.Name = "chk_Cust_ID";
            this.chk_Cust_ID.Size = new System.Drawing.Size(93, 19);
            this.chk_Cust_ID.TabIndex = 12;
            this.chk_Cust_ID.Text = "Customer ID";
            this.chk_Cust_ID.UseVisualStyleBackColor = true;
            // 
            // chk_Select_All
            // 
            this.chk_Select_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Select_All.AutoSize = true;
            this.chk_Select_All.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Select_All.Location = new System.Drawing.Point(12, 377);
            this.chk_Select_All.Name = "chk_Select_All";
            this.chk_Select_All.Size = new System.Drawing.Size(81, 21);
            this.chk_Select_All.TabIndex = 45;
            this.chk_Select_All.Text = "Select All";
            this.chk_Select_All.UseVisualStyleBackColor = true;
            this.chk_Select_All.CheckedChanged += new System.EventHandler(this.chk_Select_All_CheckedChanged);
            // 
            // chk_Unselect
            // 
            this.chk_Unselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Unselect.AutoSize = true;
            this.chk_Unselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Unselect.Location = new System.Drawing.Point(102, 377);
            this.chk_Unselect.Name = "chk_Unselect";
            this.chk_Unselect.Size = new System.Drawing.Size(97, 21);
            this.chk_Unselect.TabIndex = 46;
            this.chk_Unselect.Text = "Unselect All";
            this.chk_Unselect.UseVisualStyleBackColor = true;
            this.chk_Unselect.CheckedChanged += new System.EventHandler(this.chk_Unselect_CheckedChanged);
            // 
            // btn_Print_Preview
            // 
            this.btn_Print_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print_Preview.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Print_Preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print_Preview.ForeColor = System.Drawing.Color.White;
            this.btn_Print_Preview.Location = new System.Drawing.Point(497, 375);
            this.btn_Print_Preview.Name = "btn_Print_Preview";
            this.btn_Print_Preview.Size = new System.Drawing.Size(116, 23);
            this.btn_Print_Preview.TabIndex = 44;
            this.btn_Print_Preview.Text = "Print Preview";
            this.btn_Print_Preview.UseVisualStyleBackColor = false;
            this.btn_Print_Preview.Click += new System.EventHandler(this.btn_Print_Preview_Click);
            // 
            // btn_Batch
            // 
            this.btn_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Batch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Batch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Batch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Batch.ForeColor = System.Drawing.Color.White;
            this.btn_Batch.Location = new System.Drawing.Point(619, 375);
            this.btn_Batch.Name = "btn_Batch";
            this.btn_Batch.Size = new System.Drawing.Size(116, 23);
            this.btn_Batch.TabIndex = 43;
            this.btn_Batch.Text = "Batch";
            this.btn_Batch.UseVisualStyleBackColor = false;
            this.btn_Batch.Click += new System.EventHandler(this.btn_Batch_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(375, 375);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(116, 23);
            this.btn_Print.TabIndex = 54;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Customer_Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 406);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.chk_Select_All);
            this.Controls.Add(this.chk_Unselect);
            this.Controls.Add(this.btn_Print_Preview);
            this.Controls.Add(this.btn_Batch);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Report";
            this.Text = "Customer Report Form";
            this.Load += new System.EventHandler(this.Customer_Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).EndInit();
            this.grp_filters.ResumeLayout(false);
            this.grp_filters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grp_filters;
        private System.Windows.Forms.CheckBox chk_Address;
        private System.Windows.Forms.CheckBox chk_Phone;
        private System.Windows.Forms.CheckBox chk_LN;
        private System.Windows.Forms.CheckBox chk_FN;
        private System.Windows.Forms.CheckBox chk_Cust_ID;
        private System.Windows.Forms.CheckBox chk_Select_All;
        private System.Windows.Forms.CheckBox chk_Unselect;
        private System.Windows.Forms.Button btn_Print_Preview;
        private System.Windows.Forms.Button btn_Batch;
        private System.Windows.Forms.CheckBox chk_Hire_Date;
        private System.Windows.Forms.Label lbl_Personnel;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dtg_PreviewPage;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date_from;
        private System.Windows.Forms.DateTimePicker dtp_date_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_Type;
    }
}
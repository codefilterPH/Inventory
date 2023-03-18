﻿namespace Inventory_System02.CommonSql.Reports_Dir.Item_Division
{
    partial class ItemByDivision_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemByDivision_Form));
            this.chk_Entry_Date = new System.Windows.Forms.CheckBox();
            this.chk_Cust_Address = new System.Windows.Forms.CheckBox();
            this.chk_Job = new System.Windows.Forms.CheckBox();
            this.chk_Staff_Name = new System.Windows.Forms.CheckBox();
            this.chk_Description = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_date_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_total_value = new System.Windows.Forms.Label();
            this.lbl_total_quantity = new System.Windows.Forms.Label();
            this.chk_Sup_Name = new System.Windows.Forms.CheckBox();
            this.chk_Sup_ID = new System.Windows.Forms.CheckBox();
            this.lbl_total_items = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtg_PreviewPage = new System.Windows.Forms.DataGridView();
            this.cbo_report_type = new System.Windows.Forms.ComboBox();
            this.chk_User_ID = new System.Windows.Forms.CheckBox();
            this.chk_Price = new System.Windows.Forms.CheckBox();
            this.chk_Brand = new System.Windows.Forms.CheckBox();
            this.chk_Item_Name = new System.Windows.Forms.CheckBox();
            this.grp_filters = new System.Windows.Forms.GroupBox();
            this.chk_total = new System.Windows.Forms.CheckBox();
            this.chk_Quantity = new System.Windows.Forms.CheckBox();
            this.chk_Cust_Name = new System.Windows.Forms.CheckBox();
            this.chk_Cust_ID = new System.Windows.Forms.CheckBox();
            this.chk_Trans_Ref = new System.Windows.Forms.CheckBox();
            this.chk_Item_ID = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo_sup_divi = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_sup_div = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.chk_Select_All = new System.Windows.Forms.CheckBox();
            this.chk_Unselect = new System.Windows.Forms.CheckBox();
            this.btn_Print_Preview = new System.Windows.Forms.Button();
            this.btn_Batch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).BeginInit();
            this.grp_filters.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Entry_Date
            // 
            this.chk_Entry_Date.AutoSize = true;
            this.chk_Entry_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Entry_Date.Location = new System.Drawing.Point(10, 22);
            this.chk_Entry_Date.Name = "chk_Entry_Date";
            this.chk_Entry_Date.Size = new System.Drawing.Size(79, 17);
            this.chk_Entry_Date.TabIndex = 23;
            this.chk_Entry_Date.Text = "Entry Date";
            this.chk_Entry_Date.UseVisualStyleBackColor = true;
            // 
            // chk_Cust_Address
            // 
            this.chk_Cust_Address.AutoSize = true;
            this.chk_Cust_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Cust_Address.Location = new System.Drawing.Point(291, 112);
            this.chk_Cust_Address.Name = "chk_Cust_Address";
            this.chk_Cust_Address.Size = new System.Drawing.Size(119, 17);
            this.chk_Cust_Address.TabIndex = 22;
            this.chk_Cust_Address.Text = "Customer Address";
            this.chk_Cust_Address.UseVisualStyleBackColor = true;
            // 
            // chk_Job
            // 
            this.chk_Job.AutoSize = true;
            this.chk_Job.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Job.Location = new System.Drawing.Point(460, 64);
            this.chk_Job.Name = "chk_Job";
            this.chk_Job.Size = new System.Drawing.Size(70, 17);
            this.chk_Job.TabIndex = 21;
            this.chk_Job.Text = "Job Role";
            this.chk_Job.UseVisualStyleBackColor = true;
            // 
            // chk_Staff_Name
            // 
            this.chk_Staff_Name.AutoSize = true;
            this.chk_Staff_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Staff_Name.Location = new System.Drawing.Point(460, 43);
            this.chk_Staff_Name.Name = "chk_Staff_Name";
            this.chk_Staff_Name.Size = new System.Drawing.Size(83, 17);
            this.chk_Staff_Name.TabIndex = 20;
            this.chk_Staff_Name.Text = "Staff Name";
            this.chk_Staff_Name.UseVisualStyleBackColor = true;
            // 
            // chk_Description
            // 
            this.chk_Description.AutoSize = true;
            this.chk_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Description.Location = new System.Drawing.Point(10, 111);
            this.chk_Description.Name = "chk_Description";
            this.chk_Description.Size = new System.Drawing.Size(84, 17);
            this.chk_Description.TabIndex = 15;
            this.chk_Description.Text = "Description";
            this.chk_Description.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(222, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "TO";
            // 
            // dtp_date_from
            // 
            this.dtp_date_from.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_from.CustomFormat = "yyyy-MM-dd";
            this.dtp_date_from.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_from.Location = new System.Drawing.Point(103, 12);
            this.dtp_date_from.Name = "dtp_date_from";
            this.dtp_date_from.Size = new System.Drawing.Size(117, 22);
            this.dtp_date_from.TabIndex = 37;
            this.dtp_date_from.ValueChanged += new System.EventHandler(this.dtp_date_from_ValueChanged);
            // 
            // dtp_date_to
            // 
            this.dtp_date_to.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_to.CustomFormat = "yyyy-MM-dd";
            this.dtp_date_to.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_to.Location = new System.Drawing.Point(248, 12);
            this.dtp_date_to.Name = "dtp_date_to";
            this.dtp_date_to.Size = new System.Drawing.Size(117, 22);
            this.dtp_date_to.TabIndex = 36;
            this.dtp_date_to.ValueChanged += new System.EventHandler(this.dtp_date_to_ValueChanged);
            // 
            // lbl_total_value
            // 
            this.lbl_total_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_value.AutoSize = true;
            this.lbl_total_value.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_value.Location = new System.Drawing.Point(673, 358);
            this.lbl_total_value.Name = "lbl_total_value";
            this.lbl_total_value.Size = new System.Drawing.Size(17, 17);
            this.lbl_total_value.TabIndex = 34;
            this.lbl_total_value.Text = "0";
            this.lbl_total_value.TextChanged += new System.EventHandler(this.lbl_total_value_TextChanged);
            // 
            // lbl_total_quantity
            // 
            this.lbl_total_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_quantity.AutoSize = true;
            this.lbl_total_quantity.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_quantity.Location = new System.Drawing.Point(673, 332);
            this.lbl_total_quantity.Name = "lbl_total_quantity";
            this.lbl_total_quantity.Size = new System.Drawing.Size(17, 17);
            this.lbl_total_quantity.TabIndex = 33;
            this.lbl_total_quantity.Text = "0";
            // 
            // chk_Sup_Name
            // 
            this.chk_Sup_Name.AutoSize = true;
            this.chk_Sup_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Sup_Name.Location = new System.Drawing.Point(291, 44);
            this.chk_Sup_Name.Name = "chk_Sup_Name";
            this.chk_Sup_Name.Size = new System.Drawing.Size(101, 17);
            this.chk_Sup_Name.TabIndex = 18;
            this.chk_Sup_Name.Text = "Supplier Name";
            this.chk_Sup_Name.UseVisualStyleBackColor = true;
            // 
            // chk_Sup_ID
            // 
            this.chk_Sup_ID.AutoSize = true;
            this.chk_Sup_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Sup_ID.Location = new System.Drawing.Point(291, 22);
            this.chk_Sup_ID.Name = "chk_Sup_ID";
            this.chk_Sup_ID.Size = new System.Drawing.Size(82, 17);
            this.chk_Sup_ID.TabIndex = 17;
            this.chk_Sup_ID.Text = "Supplier ID";
            this.chk_Sup_ID.UseVisualStyleBackColor = true;
            // 
            // lbl_total_items
            // 
            this.lbl_total_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_items.AutoSize = true;
            this.lbl_total_items.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_items.Location = new System.Drawing.Point(672, 305);
            this.lbl_total_items.Name = "lbl_total_items";
            this.lbl_total_items.Size = new System.Drawing.Size(17, 17);
            this.lbl_total_items.TabIndex = 32;
            this.lbl_total_items.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(604, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Items:";
            // 
            // dtg_PreviewPage
            // 
            this.dtg_PreviewPage.AllowUserToAddRows = false;
            this.dtg_PreviewPage.AllowUserToDeleteRows = false;
            this.dtg_PreviewPage.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_PreviewPage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_PreviewPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_PreviewPage.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_PreviewPage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_PreviewPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PreviewPage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_PreviewPage.Location = new System.Drawing.Point(9, 43);
            this.dtg_PreviewPage.Name = "dtg_PreviewPage";
            this.dtg_PreviewPage.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_PreviewPage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_PreviewPage.Size = new System.Drawing.Size(799, 218);
            this.dtg_PreviewPage.TabIndex = 22;
            // 
            // cbo_report_type
            // 
            this.cbo_report_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_report_type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbo_report_type.FormattingEnabled = true;
            this.cbo_report_type.Items.AddRange(new object[] {
            "Stock In",
            "Stock Out",
            "Stock Return"});
            this.cbo_report_type.Location = new System.Drawing.Point(672, 12);
            this.cbo_report_type.Name = "cbo_report_type";
            this.cbo_report_type.Size = new System.Drawing.Size(136, 25);
            this.cbo_report_type.TabIndex = 21;
            this.cbo_report_type.Text = "Stock In";
            this.cbo_report_type.SelectedIndexChanged += new System.EventHandler(this.cbo_report_type_SelectedIndexChanged);
            // 
            // chk_User_ID
            // 
            this.chk_User_ID.AutoSize = true;
            this.chk_User_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_User_ID.Location = new System.Drawing.Point(460, 22);
            this.chk_User_ID.Name = "chk_User_ID";
            this.chk_User_ID.Size = new System.Drawing.Size(63, 17);
            this.chk_User_ID.TabIndex = 19;
            this.chk_User_ID.Text = "User ID";
            this.chk_User_ID.UseVisualStyleBackColor = true;
            // 
            // chk_Price
            // 
            this.chk_Price.AutoSize = true;
            this.chk_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Price.Location = new System.Drawing.Point(142, 44);
            this.chk_Price.Name = "chk_Price";
            this.chk_Price.Size = new System.Drawing.Size(50, 17);
            this.chk_Price.TabIndex = 16;
            this.chk_Price.Text = "Price";
            this.chk_Price.UseVisualStyleBackColor = true;
            // 
            // chk_Brand
            // 
            this.chk_Brand.AutoSize = true;
            this.chk_Brand.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Brand.Location = new System.Drawing.Point(10, 89);
            this.chk_Brand.Name = "chk_Brand";
            this.chk_Brand.Size = new System.Drawing.Size(56, 17);
            this.chk_Brand.TabIndex = 14;
            this.chk_Brand.Text = "Brand";
            this.chk_Brand.UseVisualStyleBackColor = true;
            // 
            // chk_Item_Name
            // 
            this.chk_Item_Name.AutoSize = true;
            this.chk_Item_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Item_Name.Location = new System.Drawing.Point(10, 66);
            this.chk_Item_Name.Name = "chk_Item_Name";
            this.chk_Item_Name.Size = new System.Drawing.Size(82, 17);
            this.chk_Item_Name.TabIndex = 13;
            this.chk_Item_Name.Text = "Item Name";
            this.chk_Item_Name.UseVisualStyleBackColor = true;
            // 
            // grp_filters
            // 
            this.grp_filters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_filters.Controls.Add(this.chk_total);
            this.grp_filters.Controls.Add(this.chk_Quantity);
            this.grp_filters.Controls.Add(this.chk_Cust_Name);
            this.grp_filters.Controls.Add(this.chk_Cust_ID);
            this.grp_filters.Controls.Add(this.chk_Trans_Ref);
            this.grp_filters.Controls.Add(this.chk_Entry_Date);
            this.grp_filters.Controls.Add(this.chk_Cust_Address);
            this.grp_filters.Controls.Add(this.chk_Job);
            this.grp_filters.Controls.Add(this.chk_Staff_Name);
            this.grp_filters.Controls.Add(this.chk_Description);
            this.grp_filters.Controls.Add(this.chk_User_ID);
            this.grp_filters.Controls.Add(this.chk_Sup_Name);
            this.grp_filters.Controls.Add(this.chk_Sup_ID);
            this.grp_filters.Controls.Add(this.chk_Price);
            this.grp_filters.Controls.Add(this.chk_Brand);
            this.grp_filters.Controls.Add(this.chk_Item_Name);
            this.grp_filters.Controls.Add(this.chk_Item_ID);
            this.grp_filters.Location = new System.Drawing.Point(9, 288);
            this.grp_filters.Name = "grp_filters";
            this.grp_filters.Size = new System.Drawing.Size(552, 137);
            this.grp_filters.TabIndex = 20;
            this.grp_filters.TabStop = false;
            this.grp_filters.Text = "Data Fields";
            // 
            // chk_total
            // 
            this.chk_total.AutoSize = true;
            this.chk_total.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_total.Location = new System.Drawing.Point(142, 66);
            this.chk_total.Name = "chk_total";
            this.chk_total.Size = new System.Drawing.Size(51, 17);
            this.chk_total.TabIndex = 28;
            this.chk_total.Text = "Total";
            this.chk_total.UseVisualStyleBackColor = true;
            // 
            // chk_Quantity
            // 
            this.chk_Quantity.AutoSize = true;
            this.chk_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Quantity.Location = new System.Drawing.Point(142, 22);
            this.chk_Quantity.Name = "chk_Quantity";
            this.chk_Quantity.Size = new System.Drawing.Size(69, 17);
            this.chk_Quantity.TabIndex = 27;
            this.chk_Quantity.Text = "Quantity";
            this.chk_Quantity.UseVisualStyleBackColor = true;
            // 
            // chk_Cust_Name
            // 
            this.chk_Cust_Name.AutoSize = true;
            this.chk_Cust_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Cust_Name.Location = new System.Drawing.Point(291, 89);
            this.chk_Cust_Name.Name = "chk_Cust_Name";
            this.chk_Cust_Name.Size = new System.Drawing.Size(108, 17);
            this.chk_Cust_Name.TabIndex = 26;
            this.chk_Cust_Name.Text = "Customer Name";
            this.chk_Cust_Name.UseVisualStyleBackColor = true;
            // 
            // chk_Cust_ID
            // 
            this.chk_Cust_ID.AutoSize = true;
            this.chk_Cust_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Cust_ID.Location = new System.Drawing.Point(291, 66);
            this.chk_Cust_ID.Name = "chk_Cust_ID";
            this.chk_Cust_ID.Size = new System.Drawing.Size(89, 17);
            this.chk_Cust_ID.TabIndex = 25;
            this.chk_Cust_ID.Text = "Customer ID";
            this.chk_Cust_ID.UseVisualStyleBackColor = true;
            // 
            // chk_Trans_Ref
            // 
            this.chk_Trans_Ref.AutoSize = true;
            this.chk_Trans_Ref.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Trans_Ref.Location = new System.Drawing.Point(142, 89);
            this.chk_Trans_Ref.Name = "chk_Trans_Ref";
            this.chk_Trans_Ref.Size = new System.Drawing.Size(105, 17);
            this.chk_Trans_Ref.TabIndex = 24;
            this.chk_Trans_Ref.Text = "Trans Reference";
            this.chk_Trans_Ref.UseVisualStyleBackColor = true;
            // 
            // chk_Item_ID
            // 
            this.chk_Item_ID.AutoSize = true;
            this.chk_Item_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Item_ID.Location = new System.Drawing.Point(10, 44);
            this.chk_Item_ID.Name = "chk_Item_ID";
            this.chk_Item_ID.Size = new System.Drawing.Size(63, 17);
            this.chk_Item_ID.TabIndex = 12;
            this.chk_Item_ID.Text = "Item ID";
            this.chk_Item_ID.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "REPORT DATE";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbo_sup_divi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtp_date_from);
            this.tabPage1.Controls.Add(this.dtp_date_to);
            this.tabPage1.Controls.Add(this.lbl_total_value);
            this.tabPage1.Controls.Add(this.lbl_total_quantity);
            this.tabPage1.Controls.Add(this.lbl_total_items);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtg_PreviewPage);
            this.tabPage1.Controls.Add(this.cbo_report_type);
            this.tabPage1.Controls.Add(this.grp_filters);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filter Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbo_sup_divi
            // 
            this.cbo_sup_divi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_sup_divi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbo_sup_divi.FormattingEnabled = true;
            this.cbo_sup_divi.Location = new System.Drawing.Point(531, 12);
            this.cbo_sup_divi.Name = "cbo_sup_divi";
            this.cbo_sup_divi.Size = new System.Drawing.Size(136, 25);
            this.cbo_sup_divi.TabIndex = 39;
            this.cbo_sup_divi.SelectedIndexChanged += new System.EventHandler(this.cbo_sup_divi_SelectedIndexChanged);
            this.cbo_sup_divi.TextChanged += new System.EventHandler(this.cbo_sup_divi_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_sup_div);
            this.panel1.Location = new System.Drawing.Point(420, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 22);
            this.panel1.TabIndex = 41;
            // 
            // lbl_sup_div
            // 
            this.lbl_sup_div.AutoSize = true;
            this.lbl_sup_div.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_sup_div.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sup_div.Location = new System.Drawing.Point(40, 0);
            this.lbl_sup_div.Name = "lbl_sup_div";
            this.lbl_sup_div.Size = new System.Drawing.Size(65, 17);
            this.lbl_sup_div.TabIndex = 40;
            this.lbl_sup_div.Text = "SUPPLIER";
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.BackColor = System.Drawing.Color.Peru;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(472, 540);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(116, 23);
            this.btn_Print.TabIndex = 48;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // chk_Select_All
            // 
            this.chk_Select_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Select_All.AutoSize = true;
            this.chk_Select_All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_Select_All.Location = new System.Drawing.Point(15, 542);
            this.chk_Select_All.Name = "chk_Select_All";
            this.chk_Select_All.Size = new System.Drawing.Size(79, 21);
            this.chk_Select_All.TabIndex = 45;
            this.chk_Select_All.Text = "Select all";
            this.chk_Select_All.UseVisualStyleBackColor = true;
            this.chk_Select_All.CheckedChanged += new System.EventHandler(this.chk_Select_All_CheckedChanged);
            // 
            // chk_Unselect
            // 
            this.chk_Unselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_Unselect.AutoSize = true;
            this.chk_Unselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_Unselect.Location = new System.Drawing.Point(105, 542);
            this.chk_Unselect.Name = "chk_Unselect";
            this.chk_Unselect.Size = new System.Drawing.Size(95, 21);
            this.chk_Unselect.TabIndex = 47;
            this.chk_Unselect.Text = "Unselect all";
            this.chk_Unselect.UseVisualStyleBackColor = true;
            this.chk_Unselect.CheckedChanged += new System.EventHandler(this.chk_Unselect_CheckedChanged);
            // 
            // btn_Print_Preview
            // 
            this.btn_Print_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print_Preview.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Print_Preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print_Preview.ForeColor = System.Drawing.Color.White;
            this.btn_Print_Preview.Location = new System.Drawing.Point(594, 540);
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
            this.btn_Batch.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Batch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Batch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Batch.ForeColor = System.Drawing.Color.White;
            this.btn_Batch.Location = new System.Drawing.Point(716, 540);
            this.btn_Batch.Name = "btn_Batch";
            this.btn_Batch.Size = new System.Drawing.Size(116, 23);
            this.btn_Batch.TabIndex = 43;
            this.btn_Batch.Text = "Batch";
            this.btn_Batch.UseVisualStyleBackColor = false;
            this.btn_Batch.Click += new System.EventHandler(this.btn_Batch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 524);
            this.tabControl1.TabIndex = 46;
            // 
            // ItemByDivision_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 581);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.chk_Select_All);
            this.Controls.Add(this.chk_Unselect);
            this.Controls.Add(this.btn_Print_Preview);
            this.Controls.Add(this.btn_Batch);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemByDivision_Form";
            this.Text = "Item By Division Report";
            this.Load += new System.EventHandler(this.ItemByDivision_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PreviewPage)).EndInit();
            this.grp_filters.ResumeLayout(false);
            this.grp_filters.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Entry_Date;
        private System.Windows.Forms.CheckBox chk_Cust_Address;
        private System.Windows.Forms.CheckBox chk_Job;
        private System.Windows.Forms.CheckBox chk_Staff_Name;
        private System.Windows.Forms.CheckBox chk_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date_from;
        private System.Windows.Forms.DateTimePicker dtp_date_to;
        private System.Windows.Forms.Label lbl_total_value;
        private System.Windows.Forms.Label lbl_total_quantity;
        private System.Windows.Forms.CheckBox chk_Sup_Name;
        private System.Windows.Forms.CheckBox chk_Sup_ID;
        private System.Windows.Forms.Label lbl_total_items;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dtg_PreviewPage;
        private System.Windows.Forms.ComboBox cbo_report_type;
        private System.Windows.Forms.CheckBox chk_User_ID;
        private System.Windows.Forms.CheckBox chk_Price;
        private System.Windows.Forms.CheckBox chk_Brand;
        private System.Windows.Forms.CheckBox chk_Item_Name;
        private System.Windows.Forms.GroupBox grp_filters;
        private System.Windows.Forms.CheckBox chk_total;
        private System.Windows.Forms.CheckBox chk_Quantity;
        private System.Windows.Forms.CheckBox chk_Cust_Name;
        private System.Windows.Forms.CheckBox chk_Cust_ID;
        private System.Windows.Forms.CheckBox chk_Trans_Ref;
        private System.Windows.Forms.CheckBox chk_Item_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.CheckBox chk_Select_All;
        private System.Windows.Forms.CheckBox chk_Unselect;
        private System.Windows.Forms.Button btn_Print_Preview;
        private System.Windows.Forms.Button btn_Batch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_sup_div;
        private System.Windows.Forms.ComboBox cbo_sup_divi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}
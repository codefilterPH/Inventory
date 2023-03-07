﻿
namespace Inventory_System02
{
    partial class StockOutList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_main_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.view_trans_out = new System.Windows.Forms.ToolStripMenuItem();
            this.view_table_result = new System.Windows.Forms.ToolStripMenuItem();
            this.batchTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curTransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batch_table_result = new System.Windows.Forms.ToolStripMenuItem();
            this.printInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.print_table_result = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostProductPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leastProductPurchasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostItemPurchasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostItemPurchasedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionWithTheLeastPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Trans_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.out_amt = new System.Windows.Forms.Label();
            this.out_qty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cust_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cust_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cust_Image = new System.Windows.Forms.PictureBox();
            this.lbl_items_count = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_srch_type = new System.Windows.Forms.ComboBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.dtg_outlist = new System.Windows.Forms.DataGridView();
            this.chk_select_all = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(59, 118);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(121, 22);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Location = new System.Drawing.Point(670, 118);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshTableToolStripMenuItem,
            this.view_main_btn,
            this.batchTransactionToolStripMenuItem,
            this.printInvoiceToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshTableToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshTableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshTableToolStripMenuItem.Image")));
            this.refreshTableToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // view_main_btn
            // 
            this.view_main_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.view_main_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_trans_out,
            this.view_table_result});
            this.view_main_btn.ForeColor = System.Drawing.Color.White;
            this.view_main_btn.Image = ((System.Drawing.Image)(resources.GetObject("view_main_btn.Image")));
            this.view_main_btn.Name = "view_main_btn";
            this.view_main_btn.Size = new System.Drawing.Size(60, 20);
            this.view_main_btn.Text = "View";
            // 
            // view_trans_out
            // 
            this.view_trans_out.BackColor = System.Drawing.Color.Peru;
            this.view_trans_out.ForeColor = System.Drawing.Color.White;
            this.view_trans_out.Name = "view_trans_out";
            this.view_trans_out.Size = new System.Drawing.Size(181, 22);
            this.view_trans_out.Text = "Selected Transaction";
            this.view_trans_out.Click += new System.EventHandler(this.curTransactionToolStripMenuItem_Click);
            // 
            // view_table_result
            // 
            this.view_table_result.BackColor = System.Drawing.Color.SteelBlue;
            this.view_table_result.ForeColor = System.Drawing.Color.White;
            this.view_table_result.Name = "view_table_result";
            this.view_table_result.Size = new System.Drawing.Size(181, 22);
            this.view_table_result.Text = "Table Result";
            this.view_table_result.Click += new System.EventHandler(this.view_table_result_Click);
            // 
            // batchTransactionToolStripMenuItem
            // 
            this.batchTransactionToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.batchTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curTransToolStripMenuItem,
            this.batch_table_result});
            this.batchTransactionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.batchTransactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("batchTransactionToolStripMenuItem.Image")));
            this.batchTransactionToolStripMenuItem.Name = "batchTransactionToolStripMenuItem";
            this.batchTransactionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.batchTransactionToolStripMenuItem.Text = "Batch";
            // 
            // curTransToolStripMenuItem
            // 
            this.curTransToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.curTransToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.curTransToolStripMenuItem.Name = "curTransToolStripMenuItem";
            this.curTransToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.curTransToolStripMenuItem.Text = "Selected Transaction";
            this.curTransToolStripMenuItem.Click += new System.EventHandler(this.curTransToolStripMenuItem_Click);
            // 
            // batch_table_result
            // 
            this.batch_table_result.BackColor = System.Drawing.Color.SteelBlue;
            this.batch_table_result.ForeColor = System.Drawing.Color.White;
            this.batch_table_result.Name = "batch_table_result";
            this.batch_table_result.Size = new System.Drawing.Size(181, 22);
            this.batch_table_result.Text = "Table Result";
            this.batch_table_result.Click += new System.EventHandler(this.batch_table_result_Click);
            // 
            // printInvoiceToolStripMenuItem
            // 
            this.printInvoiceToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.printInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentTransactionToolStripMenuItem,
            this.print_table_result});
            this.printInvoiceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printInvoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printInvoiceToolStripMenuItem.Image")));
            this.printInvoiceToolStripMenuItem.Name = "printInvoiceToolStripMenuItem";
            this.printInvoiceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printInvoiceToolStripMenuItem.Text = "Print";
            // 
            // currentTransactionToolStripMenuItem
            // 
            this.currentTransactionToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.currentTransactionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.currentTransactionToolStripMenuItem.Name = "currentTransactionToolStripMenuItem";
            this.currentTransactionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.currentTransactionToolStripMenuItem.Text = "Selected Transaction";
            this.currentTransactionToolStripMenuItem.Click += new System.EventHandler(this.currentTransactionToolStripMenuItem_Click);
            // 
            // print_table_result
            // 
            this.print_table_result.BackColor = System.Drawing.Color.SteelBlue;
            this.print_table_result.ForeColor = System.Drawing.Color.White;
            this.print_table_result.Name = "print_table_result";
            this.print_table_result.Size = new System.Drawing.Size(183, 22);
            this.print_table_result.Text = "Table Result";
            this.print_table_result.Click += new System.EventHandler(this.print_table_result_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostProductPurchaseToolStripMenuItem,
            this.leastProductPurchasedToolStripMenuItem,
            this.mostItemPurchasedToolStripMenuItem,
            this.mostItemPurchasedToolStripMenuItem1,
            this.mosToolStripMenuItem,
            this.divisionWithTheLeastPurchasesToolStripMenuItem});
            this.filtersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filtersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filtersToolStripMenuItem.Image")));
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.filtersToolStripMenuItem.Text = "Special Information";
            // 
            // mostProductPurchaseToolStripMenuItem
            // 
            this.mostProductPurchaseToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.mostProductPurchaseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mostProductPurchaseToolStripMenuItem.Name = "mostProductPurchaseToolStripMenuItem";
            this.mostProductPurchaseToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.mostProductPurchaseToolStripMenuItem.Text = "Most Brand Purchased";
            this.mostProductPurchaseToolStripMenuItem.Click += new System.EventHandler(this.mostProductPurchaseToolStripMenuItem_Click);
            // 
            // leastProductPurchasedToolStripMenuItem
            // 
            this.leastProductPurchasedToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.leastProductPurchasedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.leastProductPurchasedToolStripMenuItem.Name = "leastProductPurchasedToolStripMenuItem";
            this.leastProductPurchasedToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.leastProductPurchasedToolStripMenuItem.Text = "Least Brand Purchased";
            this.leastProductPurchasedToolStripMenuItem.Click += new System.EventHandler(this.leastProductPurchasedToolStripMenuItem_Click);
            // 
            // mostItemPurchasedToolStripMenuItem
            // 
            this.mostItemPurchasedToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.mostItemPurchasedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mostItemPurchasedToolStripMenuItem.Name = "mostItemPurchasedToolStripMenuItem";
            this.mostItemPurchasedToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.mostItemPurchasedToolStripMenuItem.Text = "Most Item Purchased";
            this.mostItemPurchasedToolStripMenuItem.Click += new System.EventHandler(this.mostItemPurchasedToolStripMenuItem_Click);
            // 
            // mostItemPurchasedToolStripMenuItem1
            // 
            this.mostItemPurchasedToolStripMenuItem1.BackColor = System.Drawing.Color.Peru;
            this.mostItemPurchasedToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.mostItemPurchasedToolStripMenuItem1.Name = "mostItemPurchasedToolStripMenuItem1";
            this.mostItemPurchasedToolStripMenuItem1.Size = new System.Drawing.Size(248, 22);
            this.mostItemPurchasedToolStripMenuItem1.Text = "Least Item Purchased";
            this.mostItemPurchasedToolStripMenuItem1.Click += new System.EventHandler(this.mostItemPurchasedToolStripMenuItem1_Click);
            // 
            // mosToolStripMenuItem
            // 
            this.mosToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.mosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mosToolStripMenuItem.Name = "mosToolStripMenuItem";
            this.mosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.mosToolStripMenuItem.Text = "Division with the Most Purchases";
            this.mosToolStripMenuItem.Click += new System.EventHandler(this.mosToolStripMenuItem_Click);
            // 
            // divisionWithTheLeastPurchasesToolStripMenuItem
            // 
            this.divisionWithTheLeastPurchasesToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.divisionWithTheLeastPurchasesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.divisionWithTheLeastPurchasesToolStripMenuItem.Name = "divisionWithTheLeastPurchasesToolStripMenuItem";
            this.divisionWithTheLeastPurchasesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.divisionWithTheLeastPurchasesToolStripMenuItem.Text = "Division with the Least Purchases";
            this.divisionWithTheLeastPurchasesToolStripMenuItem.Click += new System.EventHandler(this.divisionWithTheLeastPurchasesToolStripMenuItem_Click);
            // 
            // txt_Trans_number
            // 
            this.txt_Trans_number.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Trans_number.Location = new System.Drawing.Point(155, 34);
            this.txt_Trans_number.Name = "txt_Trans_number";
            this.txt_Trans_number.Size = new System.Drawing.Size(139, 25);
            this.txt_Trans_number.TabIndex = 7;
            this.txt_Trans_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Trans_number_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Transaction Ref";
            // 
            // out_amt
            // 
            this.out_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_amt.AutoSize = true;
            this.out_amt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_amt.Location = new System.Drawing.Point(612, 428);
            this.out_amt.Name = "out_amt";
            this.out_amt.Size = new System.Drawing.Size(18, 18);
            this.out_amt.TabIndex = 90;
            this.out_amt.Text = "0";
            this.out_amt.TextChanged += new System.EventHandler(this.out_amt_TextChanged);
            // 
            // out_qty
            // 
            this.out_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.out_qty.AutoSize = true;
            this.out_qty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_qty.Location = new System.Drawing.Point(612, 401);
            this.out_qty.Name = "out_qty";
            this.out_qty.Size = new System.Drawing.Size(18, 18);
            this.out_qty.TabIndex = 89;
            this.out_qty.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 88;
            this.label5.Text = "Total Amount:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 18);
            this.label9.TabIndex = 87;
            this.label9.Text = "Total Quantity:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(408, 65);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_address.Size = new System.Drawing.Size(256, 38);
            this.txt_address.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Ship To";
            // 
            // txt_Cust_name
            // 
            this.txt_Cust_name.Location = new System.Drawing.Point(408, 34);
            this.txt_Cust_name.Name = "txt_Cust_name";
            this.txt_Cust_name.Size = new System.Drawing.Size(256, 25);
            this.txt_Cust_name.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "Division Name";
            // 
            // txt_Cust_ID
            // 
            this.txt_Cust_ID.Location = new System.Drawing.Point(155, 65);
            this.txt_Cust_ID.Name = "txt_Cust_ID";
            this.txt_Cust_ID.Size = new System.Drawing.Size(139, 25);
            this.txt_Cust_ID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Division ID";
            // 
            // cust_Image
            // 
            this.cust_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cust_Image.BackColor = System.Drawing.Color.Transparent;
            this.cust_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cust_Image.Location = new System.Drawing.Point(710, 34);
            this.cust_Image.Name = "cust_Image";
            this.cust_Image.Size = new System.Drawing.Size(85, 69);
            this.cust_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cust_Image.TabIndex = 114;
            this.cust_Image.TabStop = false;
            // 
            // lbl_items_count
            // 
            this.lbl_items_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_items_count.AutoSize = true;
            this.lbl_items_count.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items_count.Location = new System.Drawing.Point(109, 395);
            this.lbl_items_count.Name = "lbl_items_count";
            this.lbl_items_count.Size = new System.Drawing.Size(15, 16);
            this.lbl_items_count.TabIndex = 117;
            this.lbl_items_count.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 395);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 16);
            this.label16.TabIndex = 116;
            this.label16.Text = "Rows count:";
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DueDate.ForeColor = System.Drawing.Color.Red;
            this.lbl_DueDate.Location = new System.Drawing.Point(14, 94);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(0, 21);
            this.lbl_DueDate.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(186, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "By";
            // 
            // cbo_srch_type
            // 
            this.cbo_srch_type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_srch_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbo_srch_type.FormattingEnabled = true;
            this.cbo_srch_type.Items.AddRange(new object[] {
            "DATE",
            "ID",
            "NAME",
            "BRAND",
            "DESCRIPTION",
            "QUANTITY",
            "PRICE",
            "TOTAL",
            "DIVISION",
            "ADDRESS",
            "STAFF NAME",
            "JOB",
            "WARRANTY DUE DATE",
            "TRANS REF"});
            this.cbo_srch_type.Location = new System.Drawing.Point(207, 118);
            this.cbo_srch_type.Name = "cbo_srch_type";
            this.cbo_srch_type.Size = new System.Drawing.Size(87, 21);
            this.cbo_srch_type.TabIndex = 6;
            this.cbo_srch_type.Text = "DIVISION";
            this.cbo_srch_type.SelectedIndexChanged += new System.EventHandler(this.cbo_srch_type_SelectedIndexChanged);
            // 
            // btn_view
            // 
            this.btn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view.BackColor = System.Drawing.Color.SlateGray;
            this.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_view.Location = new System.Drawing.Point(408, 118);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(125, 23);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View Details";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.BackColor = System.Drawing.Color.Peru;
            this.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_select.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_select.Location = new System.Drawing.Point(539, 118);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(125, 23);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dtg_outlist
            // 
            this.dtg_outlist.AllowUserToAddRows = false;
            this.dtg_outlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtg_outlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_outlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_outlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_outlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_outlist.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_outlist.Location = new System.Drawing.Point(12, 175);
            this.dtg_outlist.Name = "dtg_outlist";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_outlist.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_outlist.RowTemplate.Height = 60;
            this.dtg_outlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_outlist.Size = new System.Drawing.Size(784, 215);
            this.dtg_outlist.TabIndex = 121;
            this.dtg_outlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_outlist_CellClick);
            this.dtg_outlist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_outlist_CellContentDoubleClick_1);
            // 
            // chk_select_all
            // 
            this.chk_select_all.AutoSize = true;
            this.chk_select_all.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chk_select_all.Location = new System.Drawing.Point(11, 152);
            this.chk_select_all.Name = "chk_select_all";
            this.chk_select_all.Size = new System.Drawing.Size(71, 17);
            this.chk_select_all.TabIndex = 122;
            this.chk_select_all.Text = "Select all";
            this.chk_select_all.UseVisualStyleBackColor = true;
            this.chk_select_all.CheckedChanged += new System.EventHandler(this.chk_select_all_CheckedChanged);
            // 
            // StockOutList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(807, 462);
            this.Controls.Add(this.chk_select_all);
            this.Controls.Add(this.dtg_outlist);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_srch_type);
            this.Controls.Add(this.lbl_DueDate);
            this.Controls.Add(this.lbl_items_count);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cust_Image);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cust_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cust_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.out_amt);
            this.Controls.Add(this.out_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Trans_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockOutList";
            this.Text = "Outbound Summary";
            this.Load += new System.EventHandler(this.StockOutList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_outlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Trans_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label out_amt;
        private System.Windows.Forms.Label out_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cust_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cust_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox cust_Image;
        private System.Windows.Forms.ToolStripMenuItem view_main_btn;
        private System.Windows.Forms.ToolStripMenuItem batchTransactionToolStripMenuItem;
        private System.Windows.Forms.Label lbl_items_count;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.ToolStripMenuItem printInvoiceToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_srch_type;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ToolStripMenuItem view_trans_out;
        private System.Windows.Forms.ToolStripMenuItem view_table_result;
        private System.Windows.Forms.ToolStripMenuItem curTransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batch_table_result;
        private System.Windows.Forms.ToolStripMenuItem currentTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem print_table_result;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostProductPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leastProductPurchasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostItemPurchasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostItemPurchasedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionWithTheLeastPurchasesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtg_outlist;
        private System.Windows.Forms.CheckBox chk_select_all;
    }
}
﻿
namespace Inventory_System02
{
    partial class AddStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStock));
            this.dtg_Items = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_brand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.definitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.btb_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_AddStock = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_preview = new System.Windows.Forms.Button();
            this.cbo_desc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_srch_type = new System.Windows.Forms.ComboBox();
            this.lbl_stock_low = new System.Windows.Forms.Label();
            this.Item_Image = new System.Windows.Forms.PictureBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.Sup_Image = new System.Windows.Forms.PictureBox();
            this.btn_searchSup = new System.Windows.Forms.Button();
            this.pic_BarCode = new System.Windows.Forms.PictureBox();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Clear_Text = new System.Windows.Forms.Button();
            this.btn_Gen = new System.Windows.Forms.Button();
            this.txt_TransRef = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ItemName = new System.Windows.Forms.ComboBox();
            this.txt_SupID = new System.Windows.Forms.TextBox();
            this.txt_Sup_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_ProductValue = new System.Windows.Forms.Label();
            this.lbl_numb_items = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_Today_Amt = new System.Windows.Forms.Label();
            this.lbl_Today_Qty = new System.Windows.Forms.Label();
            this.lbl_TotalAmt = new System.Windows.Forms.Label();
            this.lbl_TotalQty = new System.Windows.Forms.Label();
            this.Calculator_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Items)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Qty)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Items
            // 
            this.dtg_Items.AllowUserToAddRows = false;
            this.dtg_Items.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_Items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Items.EnableHeadersVisualStyles = false;
            this.dtg_Items.GridColor = System.Drawing.Color.White;
            this.dtg_Items.Location = new System.Drawing.Point(3, 23);
            this.dtg_Items.Name = "dtg_Items";
            this.dtg_Items.ReadOnly = true;
            this.dtg_Items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Items.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Items.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_Items.RowTemplate.Height = 70;
            this.dtg_Items.Size = new System.Drawing.Size(850, 196);
            this.dtg_Items.TabIndex = 0;
            this.dtg_Items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dtg_Items.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Items_CellContentDoubleClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Search.Location = new System.Drawing.Point(53, 181);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(117, 25);
            this.txt_Search.TabIndex = 21;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(322, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // cbo_brand
            // 
            this.cbo_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbo_brand.FormattingEnabled = true;
            this.cbo_brand.Location = new System.Drawing.Point(112, 101);
            this.cbo_brand.Name = "cbo_brand";
            this.cbo_brand.Size = new System.Drawing.Size(201, 25);
            this.cbo_brand.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(322, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(701, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inbound Stocks";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definitionsToolStripMenuItem,
            this.supplierListToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.batchToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.printTransactionToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // definitionsToolStripMenuItem
            // 
            this.definitionsToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.definitionsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.definitionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definitionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.definitionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("definitionsToolStripMenuItem.Image")));
            this.definitionsToolStripMenuItem.Name = "definitionsToolStripMenuItem";
            this.definitionsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.definitionsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.definitionsToolStripMenuItem.Text = "Settings";
            this.definitionsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.definitionsToolStripMenuItem.ToolTipText = "Settings";
            this.definitionsToolStripMenuItem.Click += new System.EventHandler(this.definitionsToolStripMenuItem_Click);
            // 
            // supplierListToolStripMenuItem
            // 
            this.supplierListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplierListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supplierListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierListToolStripMenuItem.Image")));
            this.supplierListToolStripMenuItem.Name = "supplierListToolStripMenuItem";
            this.supplierListToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.supplierListToolStripMenuItem.Text = "Supplier List";
            this.supplierListToolStripMenuItem.ToolTipText = "List of all suppliers";
            this.supplierListToolStripMenuItem.Click += new System.EventHandler(this.supplierListToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.ToolTipText = "Reload table";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.batchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.batchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("batchToolStripMenuItem.Image")));
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.batchToolStripMenuItem.Text = "Batch Trans Ref";
            this.batchToolStripMenuItem.Click += new System.EventHandler(this.batchToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewToolStripMenuItem.Image")));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.viewToolStripMenuItem.Text = "Preview Items By Trans Ref";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // printTransactionToolStripMenuItem
            // 
            this.printTransactionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.printTransactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTransactionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printTransactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printTransactionToolStripMenuItem.Image")));
            this.printTransactionToolStripMenuItem.Name = "printTransactionToolStripMenuItem";
            this.printTransactionToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.printTransactionToolStripMenuItem.Text = "Print Cur Trans Ref";
            this.printTransactionToolStripMenuItem.Click += new System.EventHandler(this.printTransactionToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(23, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descriptions";
            // 
            // btb_delete
            // 
            this.btb_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btb_delete.BackColor = System.Drawing.Color.DarkRed;
            this.btb_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btb_delete.FlatAppearance.BorderSize = 0;
            this.btb_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btb_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_delete.ForeColor = System.Drawing.Color.White;
            this.btb_delete.Location = new System.Drawing.Point(565, 52);
            this.btb_delete.Name = "btb_delete";
            this.btb_delete.Size = new System.Drawing.Size(107, 20);
            this.btb_delete.TabIndex = 13;
            this.btb_delete.Text = "Delete Item";
            this.btb_delete.UseVisualStyleBackColor = false;
            this.btb_delete.Click += new System.EventHandler(this.btb_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(565, 29);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 20);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Save Current";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_AddStock
            // 
            this.btn_AddStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_AddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddStock.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AddStock.FlatAppearance.BorderSize = 0;
            this.btn_AddStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddStock.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStock.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AddStock.Location = new System.Drawing.Point(565, 6);
            this.btn_AddStock.Name = "btn_AddStock";
            this.btn_AddStock.Size = new System.Drawing.Size(107, 20);
            this.btn_AddStock.TabIndex = 11;
            this.btn_AddStock.Text = "Add To List";
            this.btn_AddStock.UseVisualStyleBackColor = false;
            this.btn_AddStock.Click += new System.EventHandler(this.btn_AddStock_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Price.Location = new System.Drawing.Point(421, 70);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(127, 25);
            this.txt_Price.TabIndex = 7;
            this.txt_Price.Text = "0.00";
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Price.Click += new System.EventHandler(this.txt_Price_Click);
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            this.txt_Price.Leave += new System.EventHandler(this.txt_Price_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_preview);
            this.panel1.Controls.Add(this.cbo_desc);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cbo_srch_type);
            this.panel1.Controls.Add(this.lbl_stock_low);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Item_Image);
            this.panel1.Controls.Add(this.btn_upload);
            this.panel1.Controls.Add(this.Sup_Image);
            this.panel1.Controls.Add(this.btn_searchSup);
            this.panel1.Controls.Add(this.pic_BarCode);
            this.panel1.Controls.Add(this.txt_Barcode);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_Clear_Text);
            this.panel1.Controls.Add(this.btn_Gen);
            this.panel1.Controls.Add(this.txt_TransRef);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_ItemName);
            this.panel1.Controls.Add(this.txt_SupID);
            this.panel1.Controls.Add(this.txt_Sup_Name);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Qty);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.btb_delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.cbo_brand);
            this.panel1.Controls.Add(this.btn_AddStock);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 214);
            this.panel1.TabIndex = 20;
            // 
            // btn_preview
            // 
            this.btn_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_preview.FlatAppearance.BorderSize = 0;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_preview.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(565, 121);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(107, 20);
            this.btn_preview.TabIndex = 75;
            this.btn_preview.Text = "Preview Item";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // cbo_desc
            // 
            this.cbo_desc.Location = new System.Drawing.Point(112, 132);
            this.cbo_desc.Multiline = true;
            this.cbo_desc.Name = "cbo_desc";
            this.cbo_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cbo_desc.Size = new System.Drawing.Size(202, 43);
            this.cbo_desc.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(176, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "Search by";
            // 
            // cbo_srch_type
            // 
            this.cbo_srch_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_srch_type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_srch_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbo_srch_type.FormattingEnabled = true;
            this.cbo_srch_type.Items.AddRange(new object[] {
            "Date",
            "Id",
            "Name",
            "Brand",
            "Description",
            "Quantity",
            "Price",
            "Supplier",
            "Job",
            "Trans Ref"});
            this.cbo_srch_type.Location = new System.Drawing.Point(233, 182);
            this.cbo_srch_type.Name = "cbo_srch_type";
            this.cbo_srch_type.Size = new System.Drawing.Size(93, 21);
            this.cbo_srch_type.TabIndex = 72;
            this.cbo_srch_type.Text = "Name";
            this.cbo_srch_type.SelectedIndexChanged += new System.EventHandler(this.cbo_srch_type_SelectedIndexChanged);
            // 
            // lbl_stock_low
            // 
            this.lbl_stock_low.AutoSize = true;
            this.lbl_stock_low.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_low.ForeColor = System.Drawing.Color.Red;
            this.lbl_stock_low.Location = new System.Drawing.Point(389, 7);
            this.lbl_stock_low.Name = "lbl_stock_low";
            this.lbl_stock_low.Size = new System.Drawing.Size(0, 21);
            this.lbl_stock_low.TabIndex = 71;
            // 
            // Item_Image
            // 
            this.Item_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Item_Image.BackColor = System.Drawing.Color.Transparent;
            this.Item_Image.Location = new System.Drawing.Point(678, 24);
            this.Item_Image.Name = "Item_Image";
            this.Item_Image.Size = new System.Drawing.Size(173, 131);
            this.Item_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Item_Image.TabIndex = 47;
            this.Item_Image.TabStop = false;
            this.Item_Image.DoubleClick += new System.EventHandler(this.Item_Image_DoubleClick);
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_upload.BackColor = System.Drawing.Color.Teal;
            this.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_upload.FlatAppearance.BorderSize = 0;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.Color.White;
            this.btn_upload.Location = new System.Drawing.Point(565, 98);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(107, 20);
            this.btn_upload.TabIndex = 15;
            this.btn_upload.Text = "Upload Image";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // Sup_Image
            // 
            this.Sup_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sup_Image.Location = new System.Drawing.Point(328, 152);
            this.Sup_Image.Name = "Sup_Image";
            this.Sup_Image.Size = new System.Drawing.Size(58, 51);
            this.Sup_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sup_Image.TabIndex = 70;
            this.Sup_Image.TabStop = false;
            // 
            // btn_searchSup
            // 
            this.btn_searchSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchSup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchSup.BackgroundImage")));
            this.btn_searchSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_searchSup.Location = new System.Drawing.Point(611, 147);
            this.btn_searchSup.Name = "btn_searchSup";
            this.btn_searchSup.Size = new System.Drawing.Size(32, 25);
            this.btn_searchSup.TabIndex = 8;
            this.btn_searchSup.UseVisualStyleBackColor = true;
            this.btn_searchSup.Click += new System.EventHandler(this.btn_searchSup_Click);
            this.btn_searchSup.MouseHover += new System.EventHandler(this.btn_searchSup_MouseHover);
            // 
            // pic_BarCode
            // 
            this.pic_BarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_BarCode.Location = new System.Drawing.Point(678, 157);
            this.pic_BarCode.Name = "pic_BarCode";
            this.pic_BarCode.Size = new System.Drawing.Size(173, 51);
            this.pic_BarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BarCode.TabIndex = 46;
            this.pic_BarCode.TabStop = false;
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Barcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Barcode.Location = new System.Drawing.Point(112, 39);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(201, 25);
            this.txt_Barcode.TabIndex = 2;
            this.txt_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Barcode.TextChanged += new System.EventHandler(this.txt_Barcode_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(24, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "BARCODE";
            // 
            // btn_Clear_Text
            // 
            this.btn_Clear_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Clear_Text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear_Text.FlatAppearance.BorderSize = 0;
            this.btn_Clear_Text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear_Text.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_Text.ForeColor = System.Drawing.Color.White;
            this.btn_Clear_Text.Location = new System.Drawing.Point(565, 75);
            this.btn_Clear_Text.Name = "btn_Clear_Text";
            this.btn_Clear_Text.Size = new System.Drawing.Size(107, 20);
            this.btn_Clear_Text.TabIndex = 14;
            this.btn_Clear_Text.Text = "Clear Text";
            this.btn_Clear_Text.UseVisualStyleBackColor = false;
            this.btn_Clear_Text.Click += new System.EventHandler(this.btn_Clear_Text_Click);
            // 
            // btn_Gen
            // 
            this.btn_Gen.BackColor = System.Drawing.Color.Silver;
            this.btn_Gen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Gen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Gen.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Gen.Location = new System.Drawing.Point(318, 6);
            this.btn_Gen.Name = "btn_Gen";
            this.btn_Gen.Size = new System.Drawing.Size(62, 25);
            this.btn_Gen.TabIndex = 0;
            this.btn_Gen.Text = "Generate";
            this.btn_Gen.UseVisualStyleBackColor = false;
            this.btn_Gen.Click += new System.EventHandler(this.btn_Gen_Click);
            // 
            // txt_TransRef
            // 
            this.txt_TransRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TransRef.Location = new System.Drawing.Point(147, 6);
            this.txt_TransRef.Name = "txt_TransRef";
            this.txt_TransRef.Size = new System.Drawing.Size(167, 25);
            this.txt_TransRef.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(5, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Transaction Reference";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ItemName.FormattingEnabled = true;
            this.txt_ItemName.Location = new System.Drawing.Point(112, 70);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(202, 25);
            this.txt_ItemName.TabIndex = 3;
            // 
            // txt_SupID
            // 
            this.txt_SupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SupID.Location = new System.Drawing.Point(482, 147);
            this.txt_SupID.Name = "txt_SupID";
            this.txt_SupID.Size = new System.Drawing.Size(127, 25);
            this.txt_SupID.TabIndex = 9;
            this.txt_SupID.TextChanged += new System.EventHandler(this.txt_SupID_TextChanged);
            // 
            // txt_Sup_Name
            // 
            this.txt_Sup_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Sup_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Sup_Name.Location = new System.Drawing.Point(482, 178);
            this.txt_Sup_Name.Name = "txt_Sup_Name";
            this.txt_Sup_Name.Size = new System.Drawing.Size(190, 25);
            this.txt_Sup_Name.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(388, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Supplier ID";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(388, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Supplier Name";
            // 
            // txt_Qty
            // 
            this.txt_Qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Qty.Location = new System.Drawing.Point(421, 40);
            this.txt_Qty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(127, 25);
            this.txt_Qty.TabIndex = 6;
            this.txt_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lbl_ProductValue);
            this.panel2.Controls.Add(this.lbl_numb_items);
            this.panel2.Controls.Add(this.dtg_Items);
            this.panel2.Location = new System.Drawing.Point(6, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 222);
            this.panel2.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Right;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(677, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 20);
            this.label17.TabIndex = 95;
            this.label17.Text = "Product Total Value";
            // 
            // lbl_ProductValue
            // 
            this.lbl_ProductValue.AutoSize = true;
            this.lbl_ProductValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_ProductValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ProductValue.Location = new System.Drawing.Point(819, 0);
            this.lbl_ProductValue.Name = "lbl_ProductValue";
            this.lbl_ProductValue.Size = new System.Drawing.Size(37, 20);
            this.lbl_ProductValue.TabIndex = 96;
            this.lbl_ProductValue.Text = "0.00";
            this.lbl_ProductValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_numb_items
            // 
            this.lbl_numb_items.AutoSize = true;
            this.lbl_numb_items.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_numb_items.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numb_items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_numb_items.Location = new System.Drawing.Point(0, 0);
            this.lbl_numb_items.Name = "lbl_numb_items";
            this.lbl_numb_items.Size = new System.Drawing.Size(0, 13);
            this.lbl_numb_items.TabIndex = 94;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(590, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Total Products";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(590, 485);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Over All Value";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(115, 485);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Today\'s Amount";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(127, 467);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "Today\'s Entries";
            // 
            // lbl_Today_Amt
            // 
            this.lbl_Today_Amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Today_Amt.AutoSize = true;
            this.lbl_Today_Amt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Today_Amt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Today_Amt.Location = new System.Drawing.Point(228, 485);
            this.lbl_Today_Amt.Name = "lbl_Today_Amt";
            this.lbl_Today_Amt.Size = new System.Drawing.Size(31, 15);
            this.lbl_Today_Amt.TabIndex = 34;
            this.lbl_Today_Amt.Text = "0.00";
            // 
            // lbl_Today_Qty
            // 
            this.lbl_Today_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Today_Qty.AutoSize = true;
            this.lbl_Today_Qty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Today_Qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Today_Qty.Location = new System.Drawing.Point(228, 467);
            this.lbl_Today_Qty.Name = "lbl_Today_Qty";
            this.lbl_Today_Qty.Size = new System.Drawing.Size(31, 15);
            this.lbl_Today_Qty.TabIndex = 33;
            this.lbl_Today_Qty.Text = "0.00";
            // 
            // lbl_TotalAmt
            // 
            this.lbl_TotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalAmt.AutoSize = true;
            this.lbl_TotalAmt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TotalAmt.Location = new System.Drawing.Point(695, 485);
            this.lbl_TotalAmt.Name = "lbl_TotalAmt";
            this.lbl_TotalAmt.Size = new System.Drawing.Size(31, 15);
            this.lbl_TotalAmt.TabIndex = 36;
            this.lbl_TotalAmt.Text = "0.00";
            // 
            // lbl_TotalQty
            // 
            this.lbl_TotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalQty.AutoSize = true;
            this.lbl_TotalQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TotalQty.Location = new System.Drawing.Point(695, 467);
            this.lbl_TotalQty.Name = "lbl_TotalQty";
            this.lbl_TotalQty.Size = new System.Drawing.Size(31, 15);
            this.lbl_TotalQty.TabIndex = 35;
            this.lbl_TotalQty.Text = "0.00";
            // 
            // Calculator_Timer
            // 
            this.Calculator_Timer.Tick += new System.EventHandler(this.Calculator_Timer_Tick);
            // 
            // AddStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 507);
            this.Controls.Add(this.lbl_TotalAmt);
            this.Controls.Add(this.lbl_TotalQty);
            this.Controls.Add(this.lbl_Today_Amt);
            this.Controls.Add(this.lbl_Today_Qty);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddStock";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Items)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Qty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Items;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_brand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem definitionsToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btb_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_AddStock;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown txt_Qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Sup_Name;
        private System.Windows.Forms.TextBox txt_SupID;
        private System.Windows.Forms.ToolStripMenuItem supplierListToolStripMenuItem;
        private System.Windows.Forms.ComboBox txt_ItemName;
        private System.Windows.Forms.Button btn_Gen;
        private System.Windows.Forms.TextBox txt_TransRef;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button btn_Clear_Text;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pic_BarCode;
        private System.Windows.Forms.PictureBox Item_Image;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_Today_Amt;
        private System.Windows.Forms.Label lbl_Today_Qty;
        private System.Windows.Forms.Label lbl_TotalAmt;
        private System.Windows.Forms.Label lbl_TotalQty;
        private System.Windows.Forms.Timer Calculator_Timer;
        private System.Windows.Forms.Button btn_searchSup;
        private System.Windows.Forms.PictureBox Sup_Image;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_ProductValue;
        private System.Windows.Forms.Label lbl_numb_items;
        private System.Windows.Forms.Label lbl_stock_low;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTransactionToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbo_srch_type;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox cbo_desc;
        private System.Windows.Forms.Button btn_preview;
    }
}


﻿namespace Inventory_System02.Return
{
    partial class ReturnToStocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnToStocks));
            this.dtg_return_list = new System.Windows.Forms.DataGridView();
            this.dtg_tobe_returned = new System.Windows.Forms.DataGridView();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.num_qty = new System.Windows.Forms.NumericUpDown();
            this.btn_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_select_all = new System.Windows.Forms.CheckBox();
            this.Item_Image = new System.Windows.Forms.PictureBox();
            this.return_items_count = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.return_amt = new System.Windows.Forms.Label();
            this.return_qty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_main_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.view_trans_return = new System.Windows.Forms.ToolStripMenuItem();
            this.view_tbl_return = new System.Windows.Forms.ToolStripMenuItem();
            this.batchTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batch_trans_return = new System.Windows.Forms.ToolStripMenuItem();
            this.batch_tbl_return = new System.Windows.Forms.ToolStripMenuItem();
            this.printInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.print_trans_return = new System.Windows.Forms.ToolStripMenuItem();
            this.print_tbl_return = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.most_brand_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.least_brand_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.most_product_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.least_product_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.most_division_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.least_division_return_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_remarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_return_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tobe_returned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Image)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_return_list
            // 
            this.dtg_return_list.AllowUserToAddRows = false;
            this.dtg_return_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtg_return_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_return_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_return_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_return_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_return_list.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_return_list.Location = new System.Drawing.Point(12, 240);
            this.dtg_return_list.Name = "dtg_return_list";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_return_list.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_return_list.RowTemplate.Height = 60;
            this.dtg_return_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_return_list.Size = new System.Drawing.Size(765, 186);
            this.dtg_return_list.TabIndex = 1;
            this.dtg_return_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_return_list_CellClick);
            // 
            // dtg_tobe_returned
            // 
            this.dtg_tobe_returned.AllowUserToAddRows = false;
            this.dtg_tobe_returned.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_tobe_returned.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_tobe_returned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_tobe_returned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_tobe_returned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_tobe_returned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_tobe_returned.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_tobe_returned.Location = new System.Drawing.Point(11, 133);
            this.dtg_tobe_returned.Name = "dtg_tobe_returned";
            this.dtg_tobe_returned.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtg_tobe_returned.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_tobe_returned.Size = new System.Drawing.Size(765, 78);
            this.dtg_tobe_returned.TabIndex = 10;
            // 
            // btn_return
            // 
            this.btn_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_return.BackColor = System.Drawing.Color.Green;
            this.btn_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_return.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_return.Location = new System.Drawing.Point(689, 64);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(87, 23);
            this.btn_return.TabIndex = 11;
            this.btn_return.Text = "Confirm Return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.Peru;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(596, 64);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(87, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(689, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Remove selected";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num_qty
            // 
            this.num_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_qty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_qty.Location = new System.Drawing.Point(410, 64);
            this.num_qty.Name = "num_qty";
            this.num_qty.Size = new System.Drawing.Size(87, 26);
            this.num_qty.TabIndex = 16;
            this.num_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_qty_KeyDown);
            // 
            // btn_change
            // 
            this.btn_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change.BackColor = System.Drawing.Color.SlateGray;
            this.btn_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_change.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_change.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_change.Location = new System.Drawing.Point(503, 64);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(87, 23);
            this.btn_change.TabIndex = 17;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(418, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "DAMAGE ( INVESTIGATED OR REPAIRED )";
            // 
            // chk_select_all
            // 
            this.chk_select_all.AutoSize = true;
            this.chk_select_all.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_select_all.Location = new System.Drawing.Point(12, 217);
            this.chk_select_all.Name = "chk_select_all";
            this.chk_select_all.Size = new System.Drawing.Size(71, 17);
            this.chk_select_all.TabIndex = 21;
            this.chk_select_all.Text = "Select all";
            this.chk_select_all.UseVisualStyleBackColor = true;
            this.chk_select_all.CheckedChanged += new System.EventHandler(this.chk_select_all_CheckedChanged);
            // 
            // Item_Image
            // 
            this.Item_Image.Location = new System.Drawing.Point(11, 27);
            this.Item_Image.Name = "Item_Image";
            this.Item_Image.Size = new System.Drawing.Size(117, 100);
            this.Item_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Item_Image.TabIndex = 22;
            this.Item_Image.TabStop = false;
            // 
            // return_items_count
            // 
            this.return_items_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.return_items_count.AutoSize = true;
            this.return_items_count.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_items_count.Location = new System.Drawing.Point(113, 434);
            this.return_items_count.Name = "return_items_count";
            this.return_items_count.Size = new System.Drawing.Size(15, 16);
            this.return_items_count.TabIndex = 125;
            this.return_items_count.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 434);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 16);
            this.label16.TabIndex = 124;
            this.label16.Text = "Rows count:";
            // 
            // return_amt
            // 
            this.return_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.return_amt.AutoSize = true;
            this.return_amt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_amt.Location = new System.Drawing.Point(619, 463);
            this.return_amt.Name = "return_amt";
            this.return_amt.Size = new System.Drawing.Size(18, 18);
            this.return_amt.TabIndex = 123;
            this.return_amt.Text = "0";
            // 
            // return_qty
            // 
            this.return_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.return_qty.AutoSize = true;
            this.return_qty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_qty.Location = new System.Drawing.Point(619, 438);
            this.return_qty.Name = "return_qty";
            this.return_qty.Size = new System.Drawing.Size(18, 18);
            this.return_qty.TabIndex = 122;
            this.return_qty.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 121;
            this.label7.Text = "Total Amount:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 18);
            this.label9.TabIndex = 120;
            this.label9.Text = "Total Quantity:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshTableToolStripMenuItem,
            this.view_main_btn,
            this.batchTransactionToolStripMenuItem,
            this.printInvoiceToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 126;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshTableToolStripMenuItem
            // 
            this.refreshTableToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshTableToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshTableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshTableToolStripMenuItem.Image")));
            this.refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            this.refreshTableToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.refreshTableToolStripMenuItem.Text = "Refresh Table";
            this.refreshTableToolStripMenuItem.Click += new System.EventHandler(this.refreshTableToolStripMenuItem_Click);
            // 
            // view_main_btn
            // 
            this.view_main_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.view_main_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_trans_return,
            this.view_tbl_return});
            this.view_main_btn.ForeColor = System.Drawing.Color.White;
            this.view_main_btn.Image = ((System.Drawing.Image)(resources.GetObject("view_main_btn.Image")));
            this.view_main_btn.Name = "view_main_btn";
            this.view_main_btn.Size = new System.Drawing.Size(60, 20);
            this.view_main_btn.Text = "View";
            // 
            // view_trans_return
            // 
            this.view_trans_return.BackColor = System.Drawing.Color.Peru;
            this.view_trans_return.ForeColor = System.Drawing.Color.White;
            this.view_trans_return.Name = "view_trans_return";
            this.view_trans_return.Size = new System.Drawing.Size(181, 22);
            this.view_trans_return.Text = "Selected Transaction";
            // 
            // view_tbl_return
            // 
            this.view_tbl_return.BackColor = System.Drawing.Color.SteelBlue;
            this.view_tbl_return.ForeColor = System.Drawing.Color.White;
            this.view_tbl_return.Name = "view_tbl_return";
            this.view_tbl_return.Size = new System.Drawing.Size(181, 22);
            this.view_tbl_return.Text = "Table Result";
            // 
            // batchTransactionToolStripMenuItem
            // 
            this.batchTransactionToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.batchTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batch_trans_return,
            this.batch_tbl_return});
            this.batchTransactionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.batchTransactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("batchTransactionToolStripMenuItem.Image")));
            this.batchTransactionToolStripMenuItem.Name = "batchTransactionToolStripMenuItem";
            this.batchTransactionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.batchTransactionToolStripMenuItem.Text = "Batch";
            // 
            // batch_trans_return
            // 
            this.batch_trans_return.BackColor = System.Drawing.Color.Peru;
            this.batch_trans_return.ForeColor = System.Drawing.Color.White;
            this.batch_trans_return.Name = "batch_trans_return";
            this.batch_trans_return.Size = new System.Drawing.Size(181, 22);
            this.batch_trans_return.Text = "Selected Transaction";
            // 
            // batch_tbl_return
            // 
            this.batch_tbl_return.BackColor = System.Drawing.Color.SteelBlue;
            this.batch_tbl_return.ForeColor = System.Drawing.Color.White;
            this.batch_tbl_return.Name = "batch_tbl_return";
            this.batch_tbl_return.Size = new System.Drawing.Size(181, 22);
            this.batch_tbl_return.Text = "Table Result";
            // 
            // printInvoiceToolStripMenuItem
            // 
            this.printInvoiceToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.printInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.print_trans_return,
            this.print_tbl_return});
            this.printInvoiceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printInvoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printInvoiceToolStripMenuItem.Image")));
            this.printInvoiceToolStripMenuItem.Name = "printInvoiceToolStripMenuItem";
            this.printInvoiceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printInvoiceToolStripMenuItem.Text = "Print";
            // 
            // print_trans_return
            // 
            this.print_trans_return.BackColor = System.Drawing.Color.Peru;
            this.print_trans_return.ForeColor = System.Drawing.Color.White;
            this.print_trans_return.Name = "print_trans_return";
            this.print_trans_return.Size = new System.Drawing.Size(183, 22);
            this.print_trans_return.Text = "Selected Transaction";
            // 
            // print_tbl_return
            // 
            this.print_tbl_return.BackColor = System.Drawing.Color.SteelBlue;
            this.print_tbl_return.ForeColor = System.Drawing.Color.White;
            this.print_tbl_return.Name = "print_tbl_return";
            this.print_tbl_return.Size = new System.Drawing.Size(183, 22);
            this.print_tbl_return.Text = "Table Result";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.most_brand_return_tool,
            this.least_brand_return_tool,
            this.most_product_return_tool,
            this.least_product_return_tool,
            this.most_division_return_tool,
            this.least_division_return_tool});
            this.filtersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filtersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filtersToolStripMenuItem.Image")));
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.filtersToolStripMenuItem.Text = "Special Information";
            // 
            // most_brand_return_tool
            // 
            this.most_brand_return_tool.BackColor = System.Drawing.Color.Peru;
            this.most_brand_return_tool.ForeColor = System.Drawing.Color.White;
            this.most_brand_return_tool.Name = "most_brand_return_tool";
            this.most_brand_return_tool.Size = new System.Drawing.Size(242, 22);
            this.most_brand_return_tool.Text = "Most Brand Returned";
            // 
            // least_brand_return_tool
            // 
            this.least_brand_return_tool.BackColor = System.Drawing.Color.SteelBlue;
            this.least_brand_return_tool.ForeColor = System.Drawing.Color.White;
            this.least_brand_return_tool.Name = "least_brand_return_tool";
            this.least_brand_return_tool.Size = new System.Drawing.Size(242, 22);
            this.least_brand_return_tool.Text = "Least Brand Returned";
            // 
            // most_product_return_tool
            // 
            this.most_product_return_tool.BackColor = System.Drawing.Color.Gray;
            this.most_product_return_tool.ForeColor = System.Drawing.Color.White;
            this.most_product_return_tool.Name = "most_product_return_tool";
            this.most_product_return_tool.Size = new System.Drawing.Size(242, 22);
            this.most_product_return_tool.Text = "Product with the Most Returns";
            // 
            // least_product_return_tool
            // 
            this.least_product_return_tool.BackColor = System.Drawing.Color.Peru;
            this.least_product_return_tool.ForeColor = System.Drawing.Color.White;
            this.least_product_return_tool.Name = "least_product_return_tool";
            this.least_product_return_tool.Size = new System.Drawing.Size(242, 22);
            this.least_product_return_tool.Text = "Product with the Least Returns";
            // 
            // most_division_return_tool
            // 
            this.most_division_return_tool.BackColor = System.Drawing.Color.SteelBlue;
            this.most_division_return_tool.ForeColor = System.Drawing.Color.White;
            this.most_division_return_tool.Name = "most_division_return_tool";
            this.most_division_return_tool.Size = new System.Drawing.Size(242, 22);
            this.most_division_return_tool.Text = "Division with the Most Returnee";
            // 
            // least_division_return_tool
            // 
            this.least_division_return_tool.BackColor = System.Drawing.Color.Gray;
            this.least_division_return_tool.ForeColor = System.Drawing.Color.White;
            this.least_division_return_tool.Name = "least_division_return_tool";
            this.least_division_return_tool.Size = new System.Drawing.Size(242, 22);
            this.least_division_return_tool.Text = "Division with the Least Returnee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(366, 34);
            this.textBox1.TabIndex = 127;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_remarks.AutoSize = true;
            this.txt_remarks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(343, 93);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(60, 17);
            this.txt_remarks.TabIndex = 128;
            this.txt_remarks.Text = "Remarks";
            // 
            // ReturnToStocks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.return_items_count);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.return_amt);
            this.Controls.Add(this.return_qty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Item_Image);
            this.Controls.Add(this.chk_select_all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.num_qty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.dtg_tobe_returned);
            this.Controls.Add(this.dtg_return_list);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnToStocks";
            this.Text = "Return to Stock";
            this.Load += new System.EventHandler(this.ReturnToStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_return_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tobe_returned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item_Image)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_return_list;
        private System.Windows.Forms.DataGridView dtg_tobe_returned;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown num_qty;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_select_all;
        private System.Windows.Forms.PictureBox Item_Image;
        private System.Windows.Forms.Label return_items_count;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label return_amt;
        private System.Windows.Forms.Label return_qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_main_btn;
        private System.Windows.Forms.ToolStripMenuItem view_trans_return;
        private System.Windows.Forms.ToolStripMenuItem view_tbl_return;
        private System.Windows.Forms.ToolStripMenuItem batchTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batch_trans_return;
        private System.Windows.Forms.ToolStripMenuItem batch_tbl_return;
        private System.Windows.Forms.ToolStripMenuItem printInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem print_trans_return;
        private System.Windows.Forms.ToolStripMenuItem print_tbl_return;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem most_brand_return_tool;
        private System.Windows.Forms.ToolStripMenuItem least_brand_return_tool;
        private System.Windows.Forms.ToolStripMenuItem most_product_return_tool;
        private System.Windows.Forms.ToolStripMenuItem least_product_return_tool;
        private System.Windows.Forms.ToolStripMenuItem most_division_return_tool;
        private System.Windows.Forms.ToolStripMenuItem least_division_return_tool;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_remarks;
    }
}
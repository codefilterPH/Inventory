﻿using Inventory_System02.Includes;
using Inventory_System02.Reports_Dir;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System02.CommonSql.Reports_Dir.Item_Qty
{
    public partial class Item_by_Quantity : Form
    {
        SQLConfig config;
        DataSet ds;
        ReportDataSource rs;
        ReportParameterCollection reportParameters;
        Report_Viewer frm;
        usableFunction func;
        List<Class_Item_Var> list2;

        string Global_ID, Fullname, JobRole;
        string sql;
        string company_name = string.Empty;
        string company_address = string.Empty;
        string db_table = string.Empty;
        string datef = string.Empty;
        string FileName = string.Empty;
        double price = 0, quantity = 0, sub_amt = 0, total_val = 0, rows_count = 0;

        int filter_qty_from = 0;
        int filter_qty_to = 0;
        public Item_by_Quantity(int qty_from, int qty_to)
        {
            InitializeComponent();
            filter_qty_from = qty_from;
            filter_qty_to = qty_to;
            txt_qty_from.Text = qty_from.ToString();
            txt_qty_to.Text = qty_to.ToString();
        }

        private void Item_by_Quantity_Load(object sender, EventArgs e)
        {
            chk_Cust_ID.Visible = false;
            chk_Cust_Name.Visible = false;
            chk_Cust_Address.Visible = false;
            chk_Entry_Date.Checked = true;
            chk_Item_ID.Checked = true;
            chk_Item_Name.Checked = true;
            chk_Quantity.Checked = true;
            chk_Price.Checked = true;
            chk_total.Checked = true;

            cbo_report_type.DropDownStyle = ComboBoxStyle.DropDownList;
            dtp_date_to.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);
            dtp_date_from.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);
        }

        private void Group_Filtering_MustNotEmpty()
        {
            int count = 0;
            foreach (Control c in grp_filters.Controls)
            {
                if (c is System.Windows.Forms.CheckBox && ((System.Windows.Forms.CheckBox)c).Checked)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Please select at least one filter.");
                chk_Entry_Date.Checked = true;
                chk_Item_ID.Checked = true;
                chk_Item_Name.Checked = true;
                chk_Quantity.Checked = true;
                chk_Price.Checked = true;
                chk_Trans_Ref.Checked = true;
                chk_total.Checked = true;
            }
        }

        private void WhatTable_To_Select()
        {
            if (cbo_report_type.Text == "Stock In")
            {
                db_table = "`Stocks`";
            }
            else if (cbo_report_type.Text == "Stock Out")
            {
                db_table = "`Stock Out`";
            }
            else
            {
                db_table = "`Stock Returned`";
            }
        }

        private void calculate_Total()
        {
            ClearVariables();
            foreach (DataGridViewRow rw in dtg_PreviewPage.Rows)
            {
                quantity = Convert.ToDouble(rw.Cells[6].Value);
                price = Convert.ToDouble(rw.Cells[7].Value);
                sub_amt = quantity * price;
                quantity1 += quantity;
                total_val += sub_amt;
                rows_count = dtg_PreviewPage.Rows.Count;

            }
            lbl_total_items.Text = rows_count.ToString();
            lbl_total_quantity.Text = quantity1.ToString();
            lbl_total_value.Text = total_val.ToString();
        }

        public void Calculate_Filtering(string preview_or_print, string report_type)
        {
            rs = new ReportDataSource();
            reportParameters = new ReportParameterCollection();
            frm = new Report_Viewer();
            func = new usableFunction();
            config = new SQLConfig();
            ds = new DataSet();

            list2 = new List<Class_Item_Var>();

            if (string.IsNullOrWhiteSpace(dtp_date_to.Text))
            {
                func.Error_Message1 = "Report \'Date To\'";
                func.Error_Message();
                dtp_date_to.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(dtp_date_from.Text))
            {
                func.Error_Message1 = "Report \'Date From\'";
                func.Error_Message();
                dtp_date_from.Focus();
                return;
            }
            Group_Filtering_MustNotEmpty();
            WhatTable_To_Select();


            sql = "SELECT * FROM " + db_table + " WHERE  `Entry Date` between '" + dtp_date_from.Text + "' AND  '" + dtp_date_to.Text + "' AND CAST(Quantity AS INT) BETWEEN '" + filter_qty_from.ToString() +"' AND '"+filter_qty_to.ToString()+"' ORDER BY `Entry Date` DESC";

            config.Load_Datasource(sql, ds);
            config.Load_DTG(sql, dtg_PreviewPage);
            Dtg_Properties();
            calculate_Total();
            if (preview_or_print != "load")
            {
                if (cbo_report_type.Text == "Stock In")
                {
                    if (ds != null)
                    {
                        list2 = ds.Tables[0].AsEnumerable().Select(
                         dataRow => new Class_Item_Var
                         {
                             Entry_Date = dataRow.Field<string>("Entry Date").ToString(),
                             Item_ID = dataRow.Field<string>("Stock ID").ToString(),
                             Item_Name = dataRow.Field<string>("Item Name").ToString(),
                             Brand = dataRow.Field<string>("Brand").ToString(),
                             Description = dataRow.Field<string>("Description").ToString(),
                             Quantity = dataRow.Field<string>("Quantity").ToString(),
                             Price = dataRow.Field<string>("Price").ToString(),
                             Supplier_ID = dataRow.Field<string>("Supplier ID").ToString(),
                             Supplier_Name = dataRow.Field<string>("Supplier Name").ToString(),
                             Use_ID = dataRow.Field<string>("User ID").ToString(),
                             Staff_Name = dataRow.Field<string>("Warehouse Staff Name").ToString(),
                             Job_Role = dataRow.Field<string>("Job Role").ToString(),
                             Trans_Ref = dataRow.Field<string>("Transaction Reference").ToString(),
                             Amount = (Convert.ToDouble(dataRow.Field<string>("Quantity")) * Convert.ToDouble(dataRow.Field<string>("Price"))).ToString()

                         }).ToList();
                        rs.Value = list2;
                    }
                }
                else
                {
                    if (ds != null)
                    {
                        list2 = ds.Tables[0].AsEnumerable().Select(
                      dataRow => new Class_Item_Var
                      {
                          Entry_Date = dataRow.Field<string>("Entry Date"),
                          Item_ID = dataRow.Field<string>("Stock ID"),
                          Item_Name = dataRow.Field<string>("Item Name"),
                          Brand = dataRow.Field<string>("Brand"),
                          Description = dataRow.Field<string>("Description"),
                          Quantity = dataRow.Field<string>("Quantity"),
                          Price = dataRow.Field<string>("Price"),
                          Amount = dataRow.Field<string>("Total"),
                          Customer_ID = dataRow.Field<string>("Customer ID"),
                          Customer_Name = dataRow.Field<string>("Customer Name"),
                          Customer_Address = dataRow.Field<string>("Customer Address"),
                          Use_ID = dataRow.Field<string>("User ID"),
                          Staff_Name = dataRow.Field<string>("Warehouse Staff Name"),
                          Job_Role = dataRow.Field<string>("Job Role"),
                          Trans_Ref = dataRow.Field<string>("Transaction Reference"),

                      }).ToList();
                        rs.Value = list2;
                    }
                }

                rs.Name = "DataSet1";
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.ProcessingMode = ProcessingMode.Local;


                frm.reportViewer1.LocalReport.ReportPath = (Includes.AppSettings.Item_qty_RDLC_DIR + @"ItemQTY_Report.rdlc");

                //Load Text to RDLC TextBox
                reportParameters.Add(new ReportParameter("param_report_date", dtp_date_to.Text));
                reportParameters.Add(new ReportParameter("DateStart", dtp_date_from.Text));
                reportParameters.Add(new ReportParameter("DateEnd", dtp_date_to.Text));

                //Get Company Info
                sql = "Select * from Settings ";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    company_name = config.dt.Rows[0].Field<string>("Company_Name");
                    company_address = config.dt.Rows[0].Field<string>("Company Address");
                    // Includes.AppSettings.Company_DIR = config.dt.Rows[0].Field<string>("Company_Image");
                }
                if (company_name == "" || company_name == null)
                {
                    company_name = "No Company Name";
                }
                if (company_address == "" || company_address == null)
                {
                    company_address = "No Company Address";
                }

                // reportParameters.Add(new ReportParameter("Includes.AppSettings.Item_RDLC_DIR", @"C:\Users\eugen\Desktop\Inventory_System02\Inventory_System02\bin\Debug\CommonSql\Pictures\Company\Company_Logo1.PNG"));
                reportParameters.Add(new ReportParameter("CompanyName", company_name));
                reportParameters.Add(new ReportParameter("CompanyAddress", company_address));

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    reportParameters.Add(new ReportParameter("Total_Items", ds.Tables[0].Rows.Count.ToString()));
                    calculate_Total();
                    reportParameters.Add(new ReportParameter("Total_Quantity", quantity1.ToString()));
                    reportParameters.Add(new ReportParameter("Total_Value", total_val.ToString()));

                }
                else if (ds.Tables[0].Rows.Count <= 0)
                {
                    reportParameters.Add(new ReportParameter("Total_Items", 0.ToString()));
                    reportParameters.Add(new ReportParameter("Total_Quantity", 0.ToString()));
                    reportParameters.Add(new ReportParameter("Total_Value", 0.ToString()));
                }
                foreach (CheckBox chk2 in grp_filters.Controls)
                {
                    if (chk2.Checked == false)
                    {
                        reportParameters.Add(new ReportParameter("Total_Items", 0.ToString()));
                    }
                }

                //HIDING COLUMNS
                reportParameters.Add(new ReportParameter("Hide_Entry_Date", (!chk_Entry_Date.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Item_ID", (!chk_Item_ID.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Item_Name", (!chk_Item_Name.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Brand", (!chk_Brand.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Description", (!chk_Description.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Quantity", (!chk_Quantity.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Price", (!chk_Price.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Amount", (!chk_total.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Supplier_ID", (!chk_Sup_ID.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Supplier_Name", (!chk_Sup_Name.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Customer_ID", (!chk_Cust_ID.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Customer_Name", (!chk_Cust_Name.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Customer_Address", (!chk_Cust_Address.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_User_ID", (!chk_User_ID.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Staff_Name", (!chk_Staff_Name.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Job_Role", (!chk_Job.Checked).ToString()));
                reportParameters.Add(new ReportParameter("Hide_Trans_Ref", (!chk_Trans_Ref.Checked).ToString()));

                frm.reportViewer1.LocalReport.SetParameters(reportParameters);
                frm.reportViewer1.RefreshReport();

                if (preview_or_print == "preview")
                {
                    frm.ShowDialog();
                }
                else if (preview_or_print == "print")
                {
                    Print_To_The_Printer prt = new Print_To_The_Printer();
                    prt.PrintToPrinter(frm.reportViewer1.LocalReport);
                }
                else if (preview_or_print == "batch")
                {
                    if (report_type == "Stock In")
                    {
                        FileName = "Inbound Report By Quantity " + DateTime.Now.ToString("hhmmss") + ".pdf";
                    }
                    else if (report_type == "Stock Out")
                    {
                        FileName = "Outbound Report By Quantity " + DateTime.Now.ToString("hhmmss") + ".pdf";
                    }
                    else if (report_type == "Stock Return")
                    {
                        FileName = "Return Report By Quantity " + DateTime.Now.ToString("hhmmss") + ".pdf";
                    }
                    else
                    {
                        FileName = "Item Report By Quantity " + DateTime.Now.ToString("hhmmss") + ".pdf";
                    }
                    if (!string.IsNullOrWhiteSpace(FileName))
                    {
                        string extension;
                        string encoding;
                        string mimeType;
                        string[] streams;
                        Warning[] warnings;

                        Byte[] mybytes = frm.reportViewer1.LocalReport.Render("PDF", null,
                                        out extension, out encoding,
                                        out mimeType, out streams, out warnings); //for exporting to PDF  
                                                                                  //using (FileStream fs = File.Create(Server.MapPath("~/Report/") + FileName))
                        using (FileStream fs = File.Create((Includes.AppSettings.Doc_DIR) + FileName))
                        {
                            fs.Write(mybytes, 0, mybytes.Length);

                            MessageBox.Show("Batched!", "Send to Document Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                }

            }

        }


        private void chk_Unselect_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Unselect.Checked == true)
            {
                foreach (CheckBox ch in grp_filters.Controls)
                {
                    if (ch is CheckBox)
                    {
                        ch.Checked = false;
                        chk_Select_All.Checked = false;

                    }
                }
            }

        }
    
        private void cbo_report_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_report_type.Text == "Stock In")
            {
                chk_Cust_ID.Visible = false;
                chk_Cust_Name.Visible = false;
                chk_Cust_Address.Visible = false;

                chk_Sup_ID.Visible = true;
                chk_Sup_Name.Visible = true;
            }
            else
            {
                chk_Cust_ID.Visible = true;
                chk_Cust_Name.Visible = true;
                chk_Cust_Address.Visible = true;

                chk_Sup_ID.Visible = false;
                chk_Sup_Name.Visible = false;
            }
            calculate_Total();
            Calculate_Filtering("load_todtg", cbo_report_type.Text);
        }

        private void Dtg_Properties()
        {
            dtg_PreviewPage.Columns["Entry Date"].DisplayIndex = 0;
            dtg_PreviewPage.Columns["Stock ID"].DisplayIndex = 1;
            dtg_PreviewPage.Columns["Item Name"].DisplayIndex = 2;
            dtg_PreviewPage.Columns["Brand"].DisplayIndex = 3;
            dtg_PreviewPage.Columns["Description"].DisplayIndex = 4;
            dtg_PreviewPage.Columns["Quantity"].DisplayIndex = 5;
            dtg_PreviewPage.Columns["Price"].DisplayIndex = 6;

            if (cbo_report_type.Text == "Stock In")
            {
                dtg_PreviewPage.Columns["Supplier ID"].DisplayIndex = 7;
                dtg_PreviewPage.Columns["Supplier Name"].DisplayIndex = 8;
                dtg_PreviewPage.Columns["Image Path"].Visible = false;
            }

            dtg_PreviewPage.Columns["count"].Visible = false;

            dtg_PreviewPage.Columns["User ID"].DisplayIndex = 9;
            dtg_PreviewPage.Columns["Warehouse Staff Name"].DisplayIndex = 10;
            dtg_PreviewPage.Columns["Job Role"].DisplayIndex = 11;
            dtg_PreviewPage.Columns["Transaction Reference"].DisplayIndex = 12;




        }

        private void chk_Select_All_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Select_All.Checked == true)
            {
                foreach (CheckBox ch in grp_filters.Controls)
                {
                    if (ch is CheckBox)
                    {
                        ch.Checked = true;
                        chk_Unselect.Checked = false;
                        if (cbo_report_type.Text == "Stock In")
                        {
                            chk_Cust_ID.Checked = false;
                            chk_Cust_Name.Checked = false;
                            chk_Cust_Address.Checked = false;
                        }
                        else
                        {
                            chk_Sup_ID.Checked = false;
                            chk_Sup_Name.Checked = false;
                        }
                    }
                }
            }
            else
            {
                chk_Unselect.Checked = true;
                chk_Unselect.Checked = false;
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("print", cbo_report_type.Text);
        }

        private void txt_qty_from_TextChanged(object sender, EventArgs e)
        {
            usableFunction func = new usableFunction();
            func.TextBox_Readonly(sender, e, txt_qty_from);
        }

        private void txt_qty_to_TextChanged(object sender, EventArgs e)
        {
            usableFunction func = new usableFunction();
            func.TextBox_Readonly(sender, e, txt_qty_to);
        }

        private void dtp_date_from_ValueChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load", cbo_report_type.Text);
        }

        private void dtp_date_to_ValueChanged(object sender, EventArgs e)
        {
            Calculate_Filtering("load", cbo_report_type.Text);
        }

        private void btn_Batch_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("batch", cbo_report_type.Text);
        }

        private void btn_Print_Preview_Click(object sender, EventArgs e)
        {
            Calculate_Filtering("preview", cbo_report_type.Text);
        }

        private void ClearVariables()
        {
            quantity = 0;
            quantity1 = 0;
            price = 0;
            total_val = 0;
            sub_amt = 0;
        }
        double quantity1 = 0;
    }
}

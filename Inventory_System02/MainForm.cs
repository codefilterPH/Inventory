﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System02.Includes;

namespace Inventory_System02
{
    public partial class MainForm : Form
    {

        bool sidebarExpand;
        string Global_ID, Fullname, JobRole;
        usableFunction func = new usableFunction();



        public MainForm(string userid,string name,string acctype, string phone, string email )
        {
            InitializeComponent();
            this.Text = "Inventory Management System - Welcome "+ name;
            Global_ID = userid;
            lbl_Fullname.Text = userid + " " + name;
            lbl_Acc.Text = "Job Role " + acctype;
            lbl_Phone.Text = "Phone Number " + phone;
            lbl_Email.Text = "Email " + email;
            Fullname = name;
            JobRole = acctype;


        }
       
        private void btn_Stocks_Click(object sender, EventArgs e)
        {
           
             Panel_content_remove();
             AddStock frm = new AddStock(Global_ID, Fullname, JobRole);
             ShowFormInContainerControl(show_panel, frm);

        }
        public static void ShowFormInContainerControl(Control ctl, Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            ctl.Controls.Add(frm);


        }
        public void Panel_content_remove()
        {
            foreach (Control item in show_panel.Controls.OfType<Form>())
            {
                item.Dispose();
                show_panel.Controls.Remove(item);
            }
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            btn_Stocks_Click(sender, e);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
            func.Reload_Images(Company_Logo, "Company_Logo1", @"CommonSql\Pictures\Company\");
            Load_Company_name();


        }
        SQLConfig config = new SQLConfig();
        public void  Load_Company_name()
        {
            string sql = string.Empty;
            sql = "Select * from Settings";
            config.singleResult(sql);
            if ( config.dt.Rows.Count > 0 )
            {
                company_Name.Text = config.dt.Rows[0].Field<string>("Company_Name");
            }

        }

        public string to, from;

        private void btn_DCenter_Click(object sender, EventArgs e)
        {
            Panel_content_remove();
            Batch_Form frm = new Batch_Form(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_nav_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
  
            if (sidebarExpand)
            {
                sideBar.Width -= 45;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 45;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void btn_stocks_out_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            StockOut frm = new StockOut(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_StockOutList_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            StockOutList frm = new StockOutList(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_stockreturned_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            StockReturned frm = new StockReturned(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_stock_returned_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Stock_Returned frm = new Stock_Returned(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_settings_Click_1(object sender, EventArgs e)
        {
            Settings frm = new Settings(Global_ID, Fullname, JobRole);
            frm.ShowDialog();
        }

        private void btn_custsupp_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            CustSupplier.CustSupp frm = new CustSupplier.CustSupp(Global_ID, Fullname, JobRole, "Cust");
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_employee_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Profiles.Employees frm = new Profiles.Employees(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Login1 frm = new Login1();
            frm.ShowDialog();
        }


        private void btn_DCenter_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Batch_Form frm = new Batch_Form(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

        private void btn_reports_Click_1(object sender, EventArgs e)
        {
            Panel_content_remove();
            Reports_MainForm frm = new Reports_MainForm(Global_ID, Fullname, JobRole);
            ShowFormInContainerControl(show_panel, frm);
            func.Reload_Images(employee_Profile, Global_ID, @"CommonSql\Pictures\Employee\");
        }

    
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
            Login1 frm = new Login1();
            frm.ShowDialog();
           

        }

    }
}

﻿using Inventory_System02.Includes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_System02.CustSupplier
{
    public partial class CustSupp : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        ID_Generator gen = new ID_Generator();
        string sql, Global_ID, Fullname, JobRole, CustSup;
        string cust_path = string.Empty;
        string sup_path = string.Empty;
        string main_path = string.Empty;

        public CustSupp(string global_id, string fullname, string jobrole, string Type_of_Need)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;
            CustSup = Type_of_Need;
            cust_path = @"CommonSql\Pictures\Customers\";
            sup_path = @"CommonSql\Pictures\Suppliers\";
            string main_path = string.Empty;

        }

        private void btn_GenerateID_Click(object sender, EventArgs e)
        {
            gen.Supplier_ID();
            sql = "Select `Supplier ID` from ID_Generated where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                Sup_ID.Text = config.dt.Rows[0].Field<string>("Supplier ID");
            }
        }

        private void CustSupp_Load(object sender, EventArgs e)
        {
            supplier_refresh_Click(sender, e);
            refreshToolStripMenuItem_Click(sender, e);
            if (CustSup == "Sup")
            {
                tabControl1.SelectedTab = tabPage2;
                func.Reload_Images(Sup_Image, Sup_ID.Text, sup_path);
                Sup_ID.Focus();
            }
            else
            {
                tabControl1.SelectedTab = tabPage1;
                func.Reload_Images(Cust_Image, cust_ID.Text, cust_path);

            }
            timer1.Start();
            UnlockModels();


        }
        private void UnlockModels()
        {
            if (cust_ID.Text == "")
            {
                customerModelsToolStripMenuItem.Enabled = false;
            }
            else
            {
                customerModelsToolStripMenuItem.Enabled = true;
            }
        }

        public void btn_sup_add_Click(object sender, EventArgs e)
        {

            if (Sup_ID.Text == "" || Sup_ID.Text == null)
            {
                func.Error_Message1 = "ID";
                func.Error_Message();
                btn_GenerateID.Focus();
            }
            else if (sup_CName.Text == "" || sup_CName.Text == null)
            {
                func.Error_Message1 = "First Name";
                func.Error_Message();
                sup_CName.Focus();
            }
            else if (sup_Phone.Text == "" || sup_Phone.Text == null)
            {
                func.Error_Message1 = "Last Name";
                func.Error_Message();
                sup_Phone.Focus();
            }
            else if (sup_Phone.Text == "" || sup_Phone.Text == null)
            {
                func.Error_Message1 = "Last Name";
                func.Error_Message();
                sup_Address.Focus();
            }
            else
            {
                sql = "Insert into Supplier (`Entry Date`, `Company ID`, `Company Name`, Email ,`Phone`, Street , City, Province, `Address`) values (" +
               " '" + DateTime.Now.ToString("dd-MM-yyyy") + "' " +
               ", '" + Sup_ID.Text + "' " +
               ", '" + sup_CName.Text + "'" +
               ", '" + sup_Email.Text + "' " +
               ", '" + sup_Phone.Text + "' " +
               ", '" + sup_Street.Text + "' " +
               ", '" + sup_City.Text + "' " +
               ", '" + sup_Province.Text + "' " +
               ", '" + sup_Address.Text + "'  ) ";
                config.Execute_CUD(sql, "Unsuccessful to Record " + sup_CName.Text, "Successfully recorded " + sup_CName.Text);
                tabControl1.SelectedTab = tabPage2;
                supplier_refresh_Click(sender, e);
            }
        }

        private void btn_sup_delete_Click(object sender, EventArgs e)
        {
            if (dtg_Supplier.Rows.Count > 0)
            {
                if (Sup_ID.Text != "" || Sup_ID.Text != null)
                {
                    sql = "Delete from Supplier where `Company ID` = '" + Sup_ID.Text + "'";
                    config.Execute_CUD(sql, "Unsuccessfully to Delete " + sup_CName.Text, "Successfully Deleted " + sup_CName.Text);
                    supplier_refresh_Click(sender, e);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Supplier.Rows.Count > 0)
            {

                Sup_ID.Text = dtg_Supplier.CurrentRow.Cells[2].Value.ToString();
                sup_CName.Text = dtg_Supplier.CurrentRow.Cells[3].Value.ToString();
                sup_Email.Text = dtg_Supplier.CurrentRow.Cells[4].Value.ToString();
                sup_Phone.Text = dtg_Supplier.CurrentRow.Cells[5].Value.ToString();
                sup_Street.Text = dtg_Supplier.CurrentRow.Cells[6].Value.ToString();
                sup_City.Text = dtg_Supplier.CurrentRow.Cells[7].Value.ToString();
                sup_Province.Text = dtg_Supplier.CurrentRow.Cells[8].Value.ToString();
                sup_Address.Text = dtg_Supplier.CurrentRow.Cells[9].Value.ToString();
                func.Reload_Images(Sup_Image, Sup_ID.Text, sup_path);
                func.Change_Font_DTG(sender, e, dtg_Supplier);
                Sup_ID.Focus();
            }
        }

        private void btn_Gen_ID_Click(object sender, EventArgs e)
        {
            gen.Customer_ID();
            sql = "Select `Customer ID` from ID_Generated where count = '1' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                cust_ID.Text = config.dt.Rows[0].Field<string>("Customer ID");
            }
        }

        private void btn_Cust_add_Click(object sender, EventArgs e)
        {
            if (cust_ID.Text == null || cust_ID.Text == "")
            {
                func.Error_Message1 = "ID";
                func.Error_Message();
                cust_ID.Focus();

            }
            else if (cust_FN.Text == null || cust_LN.Text == "")
            {
                func.Error_Message1 = "First Name";
                func.Error_Message();
                cust_FN.Focus();
            }
            else if (cust_LN.Text == null || cust_LN.Text == "")
            {
                func.Error_Message1 = "Last Name";
                func.Error_Message();
                cust_LN.Focus();
            }
            else if (cust_Phone.Text == null || cust_Phone.Text == "")
            {
                func.Error_Message1 = "Phone Numbers";
                func.Error_Message();
                cust_Phone.Focus();
            }
            else if (cust_Phone.Text == null || cust_Phone.Text == "")
            {
                func.Error_Message1 = "Address";
                func.Error_Message();
                cust_SAddress.Focus();
            }
            else if (cbo_type.Text == null || cbo_type.Text == "")
            {
                func.Error_Message1 = "Customer Type";
                func.Error_Message();
                cbo_type.Focus();
            }
            else
            {
                sql = "Insert into Customer ( " +
                    " `Entry Date` " +
                    ", `Customer ID` " +
                    ",`First Name` " +
                    ",`Last Name` " +
                    ",`Phone` " +
                    ",`Address`" +
                    ",`Type`) values ( " +
                    " '" + DateTime.Now.ToString("dd-MM-yyyy") + "' " +
                    ",'" + cust_ID.Text + "' " +
                    ",'" + cust_FN.Text + "' " +
                    ",'" + cust_LN.Text + "' " +
                    ",'" + cust_Phone.Text + "' " +
                    ",'" + cust_SAddress.Text + "'" +
                    ",'" + cbo_type.Text + "')";
                config.Execute_CUD(sql, "Unable to save customer information", "Customer information successfully saved to record");
                refreshToolStripMenuItem_Click(sender, e);
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from Customer";
            config.Load_DTG(sql, dtg_Customer);
            DTG_SubProperty_Cust();
        }
        private void DTG_SubProperty_Cust()
        {
            if (dtg_Customer.Rows.Count > 0)
            {
                dtg_Customer.Columns[0].Visible = false;
                main_path = cust_path;
                Load_Images(dtg_Customer);
            }

            dtg_Customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            func.Count_person(dtg_Customer, lbl_total_cust);
        }


        private void supplier_refresh_Click(object sender, EventArgs e)
        {
            sql = "Select * from Supplier";
            config.Load_DTG(sql, dtg_Supplier);
            DTG_SubProperty_Sup();
        }
        private void DTG_SubProperty_Sup()
        {
            if (dtg_Supplier.Rows.Count > 0)
            {
                dtg_Supplier.Columns[0].Visible = false;
                main_path = sup_path;
                Load_Images(dtg_Supplier);

            }
            dtg_Supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            func.Count_person(dtg_Supplier, lbl_total_sup);
        }
        private void Load_Images(DataGridView dtg)
        {
            config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));


            foreach (DataRow rw in config.dt.Rows)
            {
                if (File.Exists(main_path + rw[2].ToString() + ".JPG"))
                {
                    rw["Image"] = File.ReadAllBytes(main_path + rw[2].ToString() + ".JPG");
                }
                else
                {
                    rw["Image"] = File.ReadAllBytes(main_path + "DONOTDELETE_SUBIMAGE.JPG");
                }
            }
            dtg.Columns["Image"].DisplayIndex = 0;

            for (int i = 0; i < dtg.Columns.Count; i++)
            {
                if (dtg.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dtg.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
        }

        private void btn_sup_edit_Click(object sender, EventArgs e)
        {
            supplier_refresh_Click(sender, e);

            if (Sup_ID.Text != "")
            {
                sql = "Update Supplier set " +
                    "`Company Name` = '" + sup_CName.Text + "'" +
                    ", Email = '" + sup_Email.Text + "' " +
                    ", Phone = '" + sup_Phone.Text + "'" +
                    ", Street = '" + sup_Street.Text + "' " +
                    ", City = '" + sup_City.Text + "' " +
                    ", Province = '" + sup_Province.Text + "' " +
                    ", Address = '" + sup_Address.Text + "'" +
                    "where `Company ID` ='" + Sup_ID.Text + "' ";
                config.Execute_CUD(sql, "Unable to update profile!", "Profile successfully updated");
                supplier_refresh_Click(sender, e);
            }
        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            func.clearTxt(tabPage1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                timer1.Start();
                func.Reload_Images(Sup_Image, Sup_ID.Text, sup_path);
                supplier_refresh_Click(sender, e);


            }
            else
            {
                refreshToolStripMenuItem_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sql = "Select Type from `Customer Type`";
            config.fiil_CBO(sql, cbo_type);
            timer1.Stop();
        }

        private void Cust_Image_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing_FOR_JPEG(Cust_Image, cust_ID.Text, cust_path);
            func.Reload_Images(Cust_Image, cust_ID.Text, cust_path);
            refreshToolStripMenuItem_Click(sender, e);

        }

        private void Sup_Image_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing_FOR_JPEG(Sup_Image, Sup_ID.Text, sup_path);
            func.Reload_Images(Sup_Image, Sup_ID.Text, sup_path);
            supplier_refresh_Click(sender, e);
        }

        private void cust_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Sup_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void customerModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustModels frm = new CustModels(cust_ID.Text, cust_FN.Text + " " + cust_LN.Text);
            frm.ShowDialog();
        }

        private void cust_ID_TextChanged(object sender, EventArgs e)
        {
            UnlockModels();
        }

        private void btn_new_customer_Click(object sender, EventArgs e)
        {
            refreshToolStripMenuItem_Click(sender, e);
            btn_Clear_Text_Click(sender, e);
            btn_Gen_ID_Click(sender, e);
            cust_ID.Focus();
            cust_ID.SelectionLength = cust_ID.Text.Length;
        }

        private void btn_new_supplier_Click(object sender, EventArgs e)
        {
            supplier_refresh_Click(sender, e);
            btn_Clear_Click(sender,e);
            btn_GenerateID_Click(sender, e);
            Sup_ID.Focus();
            Sup_ID.SelectionLength = Sup_ID.Text.Length;
        }

        private void txt_Search_sup_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Supplier where `Company ID` like '%" + txt_Search_sup.Text + "%' or `Company Name` like '%" + txt_Search_sup.Text + "%'";
            config.Load_DTG(sql, dtg_Supplier);
            DTG_SubProperty_Sup();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Customer where `Customer ID` like '%" + txt_Search.Text + "%' or `First Name` like '%" + txt_Search.Text + "%' or `Last Name` like '%"+ txt_Search.Text+"%' ";
            config.Load_DTG(sql, dtg_Customer);
            DTG_SubProperty_Cust();
        }

        private void btn_Upload_Cust_Click(object sender, EventArgs e)
        {
            if (cust_ID.Text != "")
            {
                Cust_Image_DoubleClick(sender, e);
            }
            else
            {
                cust_ID.Text = "Empty Field!";
                cust_ID.SelectionLength = cust_ID.Text.Length;
                cust_ID.Focus();
            }
        }

        private void btn_Upload_sup_Click(object sender, EventArgs e)
        {
            if (Sup_ID.Text != "")
            {
                Sup_Image_DoubleClick(sender, e);
            }
            else
            {
                Sup_ID.Text = "Empty Field!";
                Sup_ID.SelectionLength = cust_ID.Text.Length;
                Sup_ID.Focus();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            func.clearTxt(tabPage2);
        }

        private void btn_Cust_Delete_Click(object sender, EventArgs e)
        {
            if (cust_ID.Text != "" || cust_ID.Text != null)
            {
                sql = "Delete from Customer where `Customer ID` = '" + cust_ID.Text + "' ";
                config.Execute_CUD(sql, "Unable to delete customer information", "Successfully deleted customer information");
                refreshToolStripMenuItem_Click(sender, e);
            }
        }

        private void dtg_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Customer.Rows.Count > 0)
            {
                cust_ID.Text = dtg_Customer.CurrentRow.Cells[2].Value.ToString();
                cust_FN.Text = dtg_Customer.CurrentRow.Cells[3].Value.ToString();
                cust_LN.Text = dtg_Customer.CurrentRow.Cells[4].Value.ToString();
                cust_Phone.Text = dtg_Customer.CurrentRow.Cells[5].Value.ToString();
                cust_SAddress.Text = dtg_Customer.CurrentRow.Cells[6].Value.ToString();
                cbo_type.Text = dtg_Customer.CurrentRow.Cells[7].Value.ToString();

                func.Reload_Images(Cust_Image, cust_ID.Text, cust_path);
                func.Change_Font_DTG(sender, e, dtg_Customer );
                cust_ID.Focus();
            }
        }

        public void btn_Cust_edit_Click(object sender, EventArgs e)
        {
            if (cust_ID.Text != null || cust_ID.Text == "")
            {
                sql = "Update Customer set " +
                    "`First Name` = '" + cust_FN.Text + "'" +
                    ", `Last Name` = '" + cust_LN.Text + "' " +
                    ", `Phone Number` = '" + cust_Phone.Text + "'" +
                    ", `Address` = '" + cust_SAddress.Text + "' " +
                    ", Type = '" + cbo_type.Text + "' " +
                    "where `Customer ID` = '" + cust_ID.Text + "' ";
                config.Execute_CUD(sql, "Unable to update " + cust_FN.Text, "Successfully updated " + cust_FN.Text);
                refreshToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

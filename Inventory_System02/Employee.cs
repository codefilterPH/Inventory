﻿using Inventory_System02.Includes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_System02.Profiles
{
    public partial class Employees : Form
    {
        SQLConfig config = new SQLConfig();
        ID_Generator gen = new ID_Generator();
        usableFunction func = new usableFunction();
        string sql, Global_ID, Fullname, JobRole;

        public Employees(string global_id, string fullname, string jobrole)
        {
            InitializeComponent();
            Global_ID = global_id;
            Fullname = fullname;
            JobRole = jobrole;

           
        }
        private void Error_PermissionDenied()
        {
            MessageBox.Show("You do not have permission to perform this action.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" || txt_ID.Text == null)
            {
                func.Error_Message1 = "ID";
                func.Error_Message();
                btn_GenID.Focus();
            }
            else if (txt_Pass.Text == "" || txt_Pass.Text == null)
            {
                func.Error_Message1 = "Password";
                func.Error_Message();
                txt_Pass.Focus();
            }
            else if (txt_FN.Text == "" || txt_FN.Text == null)
            {
                func.Error_Message1 = "First Name";
                func.Error_Message();
                txt_FN.Focus();
            }
            else if (Global_ID == "admin" || Global_ID == "manager")
            {
                if (txt_Job_role.Text == "Programmer/Developer" || (txt_Job_role.Text == "Office Manager" && Global_ID == "manager"))
                {
                    Error_PermissionDenied();
                }
                else
                {
                    sql = "Select * from Employee where `Employee ID` = '" + txt_ID.Text + "' ";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count < 1)
                    {
                        sql = "Insert into Employee (" +
                        " `Hired Date` " +
                        ",  `Employee ID`" +
                        ", `Password`" +
                        ", `First Name` " +
                        ", `Last Name` " +
                        ", `Email` " +
                        ", `Phone Number` " +
                        ", `Address` " +
                        ", `Job Role` ) values  ( " +
                        " '" + dtp_Hired_date.Text + "' " +
                        ", '" + txt_ID.Text + "' " +
                        ", sha1('" + txt_Pass.Text + "') " +
                        ", '" + txt_FN.Text + "' " +
                        ", '" + txt_LN.Text + "' " +
                        ", '" + txt_Email.Text + "' " +
                        ", '" + txt_Phone.Text + "' " +
                        ", '" + txt_Address.Text + "' " +
                        ", '" + txt_Job_role.Text + "' ) ";
                        config.Execute_CUD(sql, "Unsuccessful to Record " + txt_Job_role.Text, "Successfully recorded " + txt_Job_role.Text);
                    }
                    else
                    {
                        MessageBox.Show("This user is already added to the Database!", "Unable to add duplicate user", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            else
            {
                Error_PermissionDenied();
            }
            reloadTableToolStripMenuItem_Click(sender, e);

        }


        private void btn_GenID_Click(object sender, EventArgs e)
        {
            gen.Employee_ID();
            sql = "Select `User ID` from ID_Generated where count = '1'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txt_ID.Text = config.dt.Rows[0].Field<string>("User ID");
            }

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            func.Reload_Images(pictureBox1, "DONOTDELETE_SUBIMAGE", Includes.AppSettings.Employee_DIR);
            reloadTableToolStripMenuItem_Click(sender, e);
            timer1.Start();
        }
        double count1 = 0;
        private void reloadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "Select * from Employee ORDER BY `Hired Date` DESC";
            config.Load_DTG(sql, dtg_User);

            if (dtg_User.Columns.Count > 0)
            {
                dtg_User.Columns[0].Visible = false;
                config.dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                int visibleRowCount = 0;
                foreach (DataGridViewRow row in dtg_User.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString().Equals("admin"))
                    {
                        if (Global_ID != "admin")
                        {
                            row.Visible = false;
                        }
                    }
                    if (row.Visible)
                    {
                        visibleRowCount++;
                    }
                }
                lbl_total_emp.Text = visibleRowCount.ToString();

                foreach (DataRow rw in config.dt.Rows)
                {
                    try
                    {
                        if (File.Exists(Includes.AppSettings.Employee_DIR + rw[2].ToString() + ".JPG"))
                        {
                            rw["Image"] = File.ReadAllBytes(Includes.AppSettings.Employee_DIR + rw[2].ToString() + ".JPG");
                        }
                        else
                        {
                            rw["Image"] = File.ReadAllBytes(Includes.AppSettings.Employee_DIR + "DONOTDELETE_SUBIMAGE.JPG");
                        }
                    }
                    catch
                    {
                        for (int i = 0; i < dtg_User.Rows.Count; i++)
                        {
                            if (File.Exists(Includes.AppSettings.Employee_DIR + dtg_User.Rows[i].Cells[2].ToString() + ".JPG"))
                            {
                                rw["Image"] = File.ReadAllBytes(Includes.AppSettings.Employee_DIR + dtg_User.Rows[i].Cells[2].ToString() + ".JPG");
                            }
                            else
                            {
                                if (0 == dtg_User.Rows.Count)
                                {
                                    rw["Image"] = File.ReadAllBytes(Includes.AppSettings.Employee_DIR + "DONOTDELETE_SUBIMAGE.JPG");
                                }
                            }
                        }
                    }

                }

                dtg_User.Columns["Image"].DisplayIndex = 0;

                for (int i = 0; i < dtg_User.Columns.Count; i++)
                {
                    if (dtg_User.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dtg_User.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                        break;
                    }
                }  
            }
            dtg_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtp_Hired_date.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);
            timer1.Start();
        }

        private void txt_Phone_MouseLeave(object sender, EventArgs e)
        {
            func.Philippine_Mobile(sender, e);
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            func.email_validation(txt_Email.Text);
        }

        private void btn_Clear_Text_Click(object sender, EventArgs e)
        {
            func.clearTxt(panel2);
        }
        private void Error_DeletingSuper_User()
        {
            MessageBox.Show("You cannot change or delete the Creator of this Application!", "Warning Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dtg_User.Rows.Count >= 1)
            {
                if (dtg_User.SelectedRows.Count == 1)
                {
                    if (dtg_User.CurrentRow.Cells[2].Value.ToString() == "admin")
                    {
                        Error_DeletingSuper_User();
                        return;
                    }
                    else if (Global_ID == "admin")
                    {
                        if (MessageBox.Show("Are you sure you want to delete " + txt_FN.Text + "?", "Warning Deletion Prompt",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql = "Delete from Employee where `Employee ID` = '" + dtg_User.CurrentRow.Cells[2].Value.ToString() + "' ";
                            config.Execute_CUD(sql, "Unable to delete employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!", "Successfully deleted employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!");
                            reloadTableToolStripMenuItem_Click(sender, e);
                        }
                    }
                    else if (Global_ID == "manager" && dtg_User.CurrentRow.Cells[2].Value.ToString() != Global_ID)
                    {
                        if (MessageBox.Show("Are you sure you want to delete " + txt_FN.Text + "?", "Warning Deletion Prompt",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql = "Delete from Employee where `Employee ID` = '" + dtg_User.CurrentRow.Cells[2].Value.ToString() + "' ";
                            config.Execute_CUD(sql, "Unable to delete employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!", "Successfully deleted employee " + dtg_User.CurrentRow.Cells[4].Value.ToString() + "!");
                            reloadTableToolStripMenuItem_Click(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You don't have permission to delete this account. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (dtg_User.SelectedRows.Count > 1)
                {
                    if (Global_ID == "admin")
                    {
                        if (MessageBox.Show("Are you sure you want to delete selected?", "Warning Deletion Prompt",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow rw in dtg_User.SelectedRows)
                            {
                                if (rw.Cells[2].Value.ToString() != "admin")
                                {
                                    sql = "Delete from Employee where `Employee ID` = '" + rw.Cells[2].Value.ToString() + "' ";
                                    config.Execute_CUD(sql, "Unable to delete " + rw.Cells[4].Value.ToString(), "Successfully deleted " + rw.Cells[4].Value.ToString() + "!");
                                }
                                else
                                {
                                    Error_DeletingSuper_User();
                                }
                            }
                            reloadTableToolStripMenuItem_Click(sender, e);
                        }
                    }
                    else if (Global_ID == "manager")
                    {
                        MessageBox.Show("You don't have permission to delete multiple accounts. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "admin")
            {
                if (Global_ID != "admin")
                {
                    Error_DeletingSuper_User();
                }
            }
            else if (txt_ID.Text == Global_ID)
            {
                // Allow the user to update their own account
                if (MessageBox.Show("Are you sure to update your profile? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    // Perform the update
                    sql = "Update Employee set " +
                        " `Hired Date` = '" + dtp_Hired_date.Text + "' " +
                        ", `First Name` = '" + txt_FN.Text + "'" +
                        ", `Last Name` = '" + txt_LN.Text + "' " +
                        ", `Email` = '" + txt_Email.Text + "' " +
                        ", `Phone Number` = '" + txt_Phone.Text + "' " +
                        ", `Address` = '" + txt_Address.Text + "' " +
                        ", `Job Role` = '" + txt_Job_role.Text + "' " +
                        " where `Employee ID` = '" + txt_ID.Text + "' ";
                    config.Execute_CUD(sql, "Unable to update profile", "Profile successfully updated!");
                }
            }
            else if (Global_ID == "admin" || Global_ID == "manager")
            {
                // Allow managers and admin to update other employees' accounts
                if (MessageBox.Show("Are you sure to update this user? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    // Perform the update
                    sql = "Update Employee set " +
                        " `Hired Date` = '" + dtp_Hired_date.Text + "' " +
                        ", `First Name` = '" + txt_FN.Text + "'" +
                        ", `Last Name` = '" + txt_LN.Text + "' " +
                        ", `Email` = '" + txt_Email.Text + "' " +
                        ", `Phone Number` = '" + txt_Phone.Text + "' " +
                        ", `Address` = '" + txt_Address.Text + "' " +
                        ", `Job Role` = '" + txt_Job_role.Text + "' " +
                        " where `Employee ID` = '" + txt_ID.Text + "' ";
                    config.Execute_CUD(sql, "Unable to update profile", "Profile successfully updated!");
                }
            }
            else
            {
                // Don't allow other employees to update accounts
                MessageBox.Show("You do not have permission to update this account.", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func.clearTxt(panel2);
            btn_GenID_Click(sender, e);
            txt_ID.Focus();
            txt_ID.SelectionLength = txt_ID.Text.Length;

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (Global_ID == "admin")
            {
                // Allow admin to change the picture of anyone, including themselves
                pictureBox1_DoubleClick(sender, e);
            }
            else if (Global_ID == "manager")
            {
                // Allow manager to change the picture of anyone except admin
                if (txt_Job_role.Text != "Programmer/Developer")
                {
                    pictureBox1_DoubleClick(sender, e);
                }
                else
                {
                    Error_PermissionDenied();
                }
            }
            else
            {
                // Others can only change their own picture
                if (txt_ID.Text == Global_ID)
                {
                    pictureBox1_DoubleClick(sender, e);
                }
                else
                {
                    Error_PermissionDenied();
                }
            }
        }

        private void btn_Change_pass_Click(object sender, EventArgs e)
        {

            if (Global_ID == "admin")
            {
                // Admin can change password for any employee
                if (MessageBox.Show("Are you sure to update your password? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txt_Pass.Text))
                    {
                        func.Error_Message1 = "Password";
                        func.Error_Message();
                        txt_Pass.Focus();
                        return;
                    }
                    sql = "Update Employee set " +
                          " `Password` = sha1('" + txt_Pass.Text + "') " +
                          " where `Employee ID` = '" + txt_ID.Text + "' ";
                    config.Execute_CUD(sql, "Unable to update password! Please Contact your Administrator.", "Password successfully updated!");
                }
                reloadTableToolStripMenuItem_Click(sender, e);
            }
            else if (Global_ID == "manager")
            {
                // Office Manager and Administrator can change password for all employees except admin
                if (txt_ID.Text == "admin")
                {
                    MessageBox.Show("You don't have permission to change the password of admin account. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure to update your password? \n\nContinue?", "Update confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txt_Pass.Text))
                    {
                        func.Error_Message1 = "Password";
                        func.Error_Message();
                        txt_Pass.Focus();
                        return;
                    }
                    sql = "Update Employee set " +
                          " `Password` = sha1('" + txt_Pass.Text + "') " +
                          " where `Employee ID` = '" + txt_ID.Text + "' ";
                    config.Execute_CUD(sql, "Unable to update password! Please Contact your Administrator.", "Password successfully updated!");
                }
                reloadTableToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Only \"Office Manager\" can change current password. Thank you!", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dtg_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_User.Rows.Count > 0)
            {
                dtp_Hired_date.Text = dtg_User.CurrentRow.Cells[1].Value.ToString();
                txt_ID.Text = dtg_User.CurrentRow.Cells[2].Value.ToString();
                txt_Pass.Text = dtg_User.CurrentRow.Cells[3].Value.ToString();
                txt_FN.Text = dtg_User.CurrentRow.Cells[4].Value.ToString();
                txt_LN.Text = dtg_User.CurrentRow.Cells[5].Value.ToString();
                txt_Email.Text = dtg_User.CurrentRow.Cells[6].Value.ToString();
                txt_Phone.Text = dtg_User.CurrentRow.Cells[7].Value.ToString();
                txt_Address.Text = dtg_User.CurrentRow.Cells[8].Value.ToString();
                txt_Job_role.Text = dtg_User.CurrentRow.Cells[9].Value.ToString();

                func.Reload_Images(pictureBox1, txt_ID.Text, Includes.AppSettings.Employee_DIR);
                func.Change_Font_DTG(sender, e, dtg_User);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sql = "Select Type from `Employee Role`";
            dtp_Hired_date.Text = DateTime.Now.ToString(Includes.AppSettings.DateFormat);
            config.fiil_CBO(sql, txt_Job_role);
            timer1.Stop();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            func.DoubleClick_Picture_Then_Replace_Existing_FOR_JPEG(pictureBox1, txt_ID.Text, Includes.AppSettings.Employee_DIR);
            reloadTableToolStripMenuItem_Click(sender, e);
            reloadTableToolStripMenuItem_Click(sender, e);
            timer1.Start();

        }
    }
}

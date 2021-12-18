using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryApp.Classes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibraryApp.Forms
{
    public partial class UserAuditForm : Form
    {
        DataSet userDs = new DataSet();
        DataSet adminDs = new DataSet();
        MySqlDataAdapter userDa;
        MySqlDataAdapter adminDa;
        MyLibraryDb db = new MyLibraryDb();
        int state = 0;
        string userSql = "SET FOREIGN_KEY_CHECKS=0; SELECT user_id AS ID, username AS Username, first_name AS 'First name', last_name AS 'Last name' FROM user;";
        string adminSql = "SET FOREIGN_KEY_CHECKS=0; SELECT admin_id AS ID, username AS Username, first_name AS 'First name', last_name AS 'Last name' FROM admin;";

        public UserAuditForm()
        {
            InitializeComponent();
            /*
            CustomFont cf = new CustomFont();
            cf.useRegular(changeBtn);
            cf.useRegular(updateBtn);
            cf.useRegular(newBtn);
            cf.useSemiBold(stateLabel);
            */
            try
            {
                userDa = new MySqlDataAdapter(userSql, db.connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(userDa);

                userDa.Fill(userDs, "user");

                accountGrid.DataSource = userDs;
                accountGrid.DataMember = "user";
                accountGrid.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void UserAuditForm_Load(object sender, EventArgs e)
        {
            accountGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            accountGrid.Columns[0].Width = 30;
            accountGrid.Columns[0].ReadOnly = true;
            newBtn.Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                userDa.Update(userDs, "user");
            }
            else
            {
                adminDa.Update(adminDs, "admin");
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == 0)
                {
                    state = 1;

                    adminDa = new MySqlDataAdapter(adminSql, db.connection);
                    MySqlCommandBuilder cb1 = new MySqlCommandBuilder(adminDa);

                    adminDs.Clear();
                    adminDa.Fill(adminDs, "admin");

                    accountGrid.DataSource = null;
                    accountGrid.Columns.Clear();
                    accountGrid.DataSource = adminDs;
                    accountGrid.DataMember = "admin";

                    stateLabel.Text = "Admin Data";
                    changeBtn.Text = "User Data";

                    accountGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    accountGrid.Columns[0].Width = 30;
                    accountGrid.Columns[0].ReadOnly = true;

                    newBtn.Visible = true;
                }
                else
                {
                    state = 0;

                    userDa = new MySqlDataAdapter(userSql, db.connection);
                    MySqlCommandBuilder cb1 = new MySqlCommandBuilder(userDa);

                    userDs.Clear();
                    userDa.Fill(userDs, "user");

                    accountGrid.DataSource = null;
                    accountGrid.Columns.Clear();
                    accountGrid.DataSource = userDs;
                    accountGrid.DataMember = "user";

                    stateLabel.Text = "User Data";
                    changeBtn.Text = "Admin Data";

                    accountGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    accountGrid.Columns[0].Width = 30;
                    accountGrid.Columns[0].ReadOnly = true;

                    newBtn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            NewAdminForm newAdminForm = new NewAdminForm(this);
            newAdminForm.ShowDialog();
        }

        public void updateAdminData()
        {
            adminDa = new MySqlDataAdapter(adminSql, db.connection);
            MySqlCommandBuilder cb1 = new MySqlCommandBuilder(adminDa);

            adminDs.Clear();
            adminDa.Fill(adminDs, "admin");

            accountGrid.DataSource = null;
            accountGrid.Columns.Clear();
            accountGrid.DataSource = adminDs;
            accountGrid.DataMember = "admin";

            accountGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            accountGrid.Columns[0].Width = 30;
            accountGrid.Columns[0].ReadOnly = true;
        }
    }
}

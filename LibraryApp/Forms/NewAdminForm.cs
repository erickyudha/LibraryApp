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
    public partial class NewAdminForm : Form
    {
        UserAuditForm userAuditForm;
        public NewAdminForm(UserAuditForm userAuditForm)
        {
            this.userAuditForm = userAuditForm;

            InitializeComponent();
            /*
            CustomFont cf = new CustomFont();
            cf.useSemiBold(label1);
            cf.useRegular(label2);
            cf.useRegular(label3);
            cf.useRegular(label4);
            cf.useRegular(label5);
            cf.useRegular(label6);
            cf.useRegular(createBtn);
            */
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string username = unameBox.Text;
            if (
                fName.TextLength < 2 || lName.TextLength < 2 ||
                unameBox.TextLength < Properties.Settings.Default.usernameMinLen ||
                password1.TextLength < Properties.Settings.Default.passwordMinLen
                )
            {
                MessageBox.Show("Register Failed: Check Input Again!");
            }
            else
            {
                if (password1.Text != password2.Text)
                {
                    MessageBox.Show("Password Confirmation Wrong!");
                }
                else
                {
                    MyLibraryDb db = new MyLibraryDb();
                    if (User.isUsernameExist(db, username) || Admin.isUsernameExist(db, username))
                    {
                        MessageBox.Show("Username Already Exist!");
                    }
                    else
                    {
                        string sql = "INSERT INTO `admin` (`admin_id`, `username`, `password`, `first_name`, `last_name`) VALUES (NULL, ?username, ?password, ?first_name, ?last_name);";
                        try
                        {
                            db.connection.Open();
                            MySqlCommand command = db.connection.CreateCommand();
                            command.CommandText = sql;
                            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = unameBox.Text;
                            command.Parameters.Add("?password", MySqlDbType.VarChar).Value = password1.Text;
                            command.Parameters.Add("?first_name", MySqlDbType.VarChar).Value = fName.Text;
                            command.Parameters.Add("?last_name", MySqlDbType.VarChar).Value = lName.Text;

                            command.ExecuteNonQuery();
                            db.connection.Close();

                            userAuditForm.updateAdminData();
                            MessageBox.Show("Registration Success");
                            this.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Register Error: " + ex.ToString());
                        }
                    }
                }
            }
        }
    }
}

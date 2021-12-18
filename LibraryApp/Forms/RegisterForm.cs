using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryApp.Forms;
using LibraryApp.Classes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibraryApp.Forms
{
    public partial class RegisterForm : Form
    {
        MainForm mainForm;
        public RegisterForm(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
            /*
            CustomFont cf = new CustomFont();
            cf.useExtraBold(label1);
            cf.useRegular(label2);
            cf.useRegular(label3);
            cf.useRegular(label4);
            cf.useRegular(label5);
            cf.useRegular(label6);
            cf.useRegular(regBtn);
            */
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string username = uname.Text;
            if (
                fName.TextLength < 2 || lName.TextLength < 2 ||
                uname.TextLength < Properties.Settings.Default.usernameMinLen || 
                password.TextLength < Properties.Settings.Default.passwordMinLen
                )
            {
                MessageBox.Show("Register Failed: Check Input Again!");
            }
            else
            {
                if (password.Text != password2.Text)
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
                        string sql = "INSERT INTO `user` (`user_id`, `username`, `password`, `first_name`, `last_name`) VALUES (NULL, ?username, ?password, ?first_name, ?last_name);";
                        try
                        {
                            db.connection.Open();
                            MySqlCommand command = db.connection.CreateCommand();
                            command.CommandText = sql;
                            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = uname.Text;
                            command.Parameters.Add("?password", MySqlDbType.VarChar).Value = password.Text;
                            command.Parameters.Add("?first_name", MySqlDbType.VarChar).Value = fName.Text;
                            command.Parameters.Add("?last_name", MySqlDbType.VarChar).Value = lName.Text;

                            command.ExecuteNonQuery();
                            db.connection.Close();

                            mainForm.Show();
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

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }
    }
}

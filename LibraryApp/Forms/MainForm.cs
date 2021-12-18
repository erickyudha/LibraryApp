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

namespace LibraryApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            DbSettingsForm setForm = new DbSettingsForm(this);
            setForm.ShowDialog();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MyLibraryDb db = new MyLibraryDb();
            string uname = usernameInput.Text;

            if (passInput.TextLength < Properties.Settings.Default.passwordMinLen ||
                usernameInput.TextLength < Properties.Settings.Default.usernameMinLen)
            {
                MessageBox.Show("Login Failed: Invalid input");
            }
            else
            {
                if (!User.isUsernameExist(db, uname) && !Admin.isUsernameExist(db, uname))
                {
                    MessageBox.Show("Login Failed: Username doesn't exist");
                }
                else
                {
                    string pass = passInput.Text;

                    if (User.isUsernameExist(db, uname))
                    {
                        User user = new User(User.getAccountData(db, uname));
                        
                        if (user.verifyPass(pass))
                        {
                            MainUserForm mainUserForm = new MainUserForm(this, user);
                            this.Hide();
                            mainUserForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed: Password wrong");
                        }
                    }
                    else if (Admin.isUsernameExist(db, uname))
                    {
                        Admin admin = new Admin(Admin.getAccountData(db, uname));

                        if (admin.verifyPass(pass))
                        {
                            MainAdminForm mainAdminForm = new MainAdminForm(this, admin);
                            this.Hide();
                            mainAdminForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed: Password wrong");
                        }
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            CustomFont cf = new CustomFont();
            cf.useExtraBold(label1);
            cf.useRegular(label2);
            cf.useRegular(label3);
            cf.useRegular(regBtn);
            cf.useRegular(loginBtn);
            cf.useRegular(settingsBtn);
            */

            settingsBtn.ImageAlign = ContentAlignment.MiddleRight;
            settingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            settingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
    }
}

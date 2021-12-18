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
    public partial class DbSettingsForm : Form
    {
        MainForm mainForm;
        public DbSettingsForm(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DbServerName = serverNameBox.Text;
            Properties.Settings.Default.DbPort = serverPortBox.Text;
            Properties.Settings.Default.DbUsername = serverUsernameBox.Text;
            Properties.Settings.Default.DbName = serverDbBox.Text;

            testConnectionSettings(Properties.Settings.Default.DbServerName, Properties.Settings.Default.DbUsername, Properties.Settings.Default.DbName, Properties.Settings.Default.DbPort);
        }

        private void testConnectionSettings(string svName, string username, string dbName, string port)
        {
            if (MyLibraryDb.isValidSettings(svName, username, dbName, port))
            {
                connectLabel.Text = "Connection active";
                connectLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                connectLabel.Text = "Connection inactive";
                connectLabel.ForeColor = Color.Red;
            }
        }

        private void DbSettingsForm_Load(object sender, EventArgs e)
        {
            /*
            CustomFont cf = new CustomFont();
            cf.useSemiBold(label1);
            cf.useRegular(label2);
            cf.useRegular(label3);
            cf.useRegular(label4);
            cf.useRegular(label5);
            cf.useRegular(saveBtn);
            cf.useRegular(connectLabel);
            */
            testConnectionSettings(Properties.Settings.Default.DbServerName, Properties.Settings.Default.DbUsername, Properties.Settings.Default.DbName, Properties.Settings.Default.DbPort);

            serverNameBox.Text = Properties.Settings.Default.DbServerName;
            serverPortBox.Text = Properties.Settings.Default.DbPort;
            serverUsernameBox.Text = Properties.Settings.Default.DbUsername;
            serverDbBox.Text = Properties.Settings.Default.DbName;
        }
    }
}

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

namespace LibraryApp.Forms
{
    public partial class MainAdminForm : Form
    {
        MainForm mainForm;
        Admin admin;
        public MainAdminForm(MainForm mainForm, Admin admin)
        {
            this.mainForm = mainForm;
            this.admin = admin;

            InitializeComponent();

            Color cust_dblue = Color.FromArgb(255, 48, 71, 94);

            panel1.BackColor = Color.FromArgb(255, 245, 245, 245);
            roleLabel.BackColor = Color.FromArgb(255, 240, 84, 84);

            /*
            CustomFont cf = new CustomFont();
            cf.useSemiBold(label1);
            cf.useBlack(label2);
            cf.useSemiBold(roleLabel);
            cf.useExtraBold(label3);
            cf.useExtraBold(bookAuditLabel);
            cf.useExtraBold(userAuditLabel);
            */
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            label2.Text = admin.getName();
        }

        private void MainAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void bookAuditPanel_Click(object sender, EventArgs e)
        {
            openBookAudit();
        }

        private void bookAuditPic_Click(object sender, EventArgs e)
        {
            openBookAudit();
        }

        private void bookAuditLabel_Click(object sender, EventArgs e)
        {
            openBookAudit();
        }

        private void openBookAudit()
        {
            BookAuditForm bookAuditForm = new BookAuditForm();
            bookAuditForm.ShowDialog();
        }

        private void userAuditPic_Click(object sender, EventArgs e)
        {
            openUserAudit();
        }

        private void userAuditLabel_Click(object sender, EventArgs e)
        {
            openUserAudit();
        }

        private void userAuditPanel_Click(object sender, EventArgs e)
        {
            openUserAudit();
        }

        private void openUserAudit()
        {
            UserAuditForm userAuditForm = new UserAuditForm();
            userAuditForm.ShowDialog();
        }

        private void transPanel_Click(object sender, EventArgs e)
        {
            openTransactionMenu();
        }

        private void transLogo_Click(object sender, EventArgs e)
        {
            openTransactionMenu();
        }

        private void transLabel_Click(object sender, EventArgs e)
        {
            openTransactionMenu();
        }

        private void openTransactionMenu()
        {
            TransactionMenu transactionMenu = new TransactionMenu(this);
            transactionMenu.ShowDialog();
        }

        public void openReturnMenu()
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog();
        }

        public void openBorrowMenu()
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm();
            borrowBookForm.ShowDialog();
        }
    }
}

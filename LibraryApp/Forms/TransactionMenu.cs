using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class TransactionMenu : Form
    {
        MainAdminForm mainAdminForm;
        public TransactionMenu(MainAdminForm mainAdminForm)
        {
            this.mainAdminForm = mainAdminForm;

            InitializeComponent();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            mainAdminForm.openBorrowMenu();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            mainAdminForm.openReturnMenu();
        }
    }
}

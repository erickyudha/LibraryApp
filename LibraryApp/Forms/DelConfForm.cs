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
    public partial class DelConfForm : Form
    {
        public DelConfForm()
        {
            InitializeComponent();

            CustomFont cf = new CustomFont();
            cf.useSemiBold(label1);
            cf.useExtraBold(yesBtn);
            cf.useRegular(noBtn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

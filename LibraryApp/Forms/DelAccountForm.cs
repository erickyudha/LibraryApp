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
    public partial class DelAccountForm : Form
    {
        public DelAccountForm()
        {
            InitializeComponent();

            CustomFont cf = new CustomFont();
            cf.useExtraBold(label1);
            cf.useSemiBold(label2);
            cf.useRegular(delBtn);
        }
    }
}

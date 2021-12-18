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
using LibraryApp.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace LibraryApp.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            MyLibraryDb db = new MyLibraryDb();


            dataGridView1.DataSource = Transaction.getTransactionData(db, 1);
            dataGridView1.DataMember = "transaction";
        }
    }
}

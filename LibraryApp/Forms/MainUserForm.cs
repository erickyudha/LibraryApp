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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace LibraryApp.Forms
{
    public partial class MainUserForm : Form
    {
        private MainForm mainForm;
        private User user;
        public MainUserForm(MainForm mainForm, User user)
        {
            this.mainForm = mainForm;
            this.user = user;

            InitializeComponent();

            uidLabel.BackColor = Color.FromArgb(255, 240, 84, 84);
            uidLabel.Text = "UserID: " + user.user_id.ToString();

            try
            {
                MyLibraryDb db = new MyLibraryDb();
                DataSet ds = new DataSet();

                string sql = "SELECT books.title AS Title, transaction.return_date AS 'Return Deadline' " +
                    "FROM transaction " +
                    "INNER JOIN books ON transaction.isbn = books.isbn " +
                    "WHERE transaction.user_id = " + user.user_id.ToString() + ";";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                adapter.Fill(ds, "transaction");

                transactionGridView.DataSource = ds;
                transactionGridView.DataMember = "transaction";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            /*
            CustomFont cf = new CustomFont();
            cf.useExtraBold(label1);
            cf.useBlack(label2);
            cf.useSemiBold(ttlLabel1);
            cf.useExtraBold(ttlLabel2);
            cf.useSemiBold(authLabel1);
            cf.useExtraBold(authLabel2);
            cf.useSemiBold(label7);
            */
        }

        private void ttlPanel_Click(object sender, EventArgs e)
        {
            openSearchTtl();
        }

        private void ttlPictureBox_Click(object sender, EventArgs e)
        {
            openSearchTtl();
        }

        private void ttlLabel1_Click(object sender, EventArgs e)
        {
            openSearchTtl();
        }

        private void ttlLabel2_Click(object sender, EventArgs e)
        {
            openSearchTtl();
        }

        private void authPanel_Click(object sender, EventArgs e)
        {
            openSearchAuth();
        }

        private void authPictureBox_Click(object sender, EventArgs e)
        {
            openSearchAuth();
        }

        private void authLabel1_Click(object sender, EventArgs e)
        {
            openSearchAuth();
        }

        private void authLabel2_Click(object sender, EventArgs e)
        {
            openSearchAuth();
        }



        private void openSearchTtl()
        {
            BookSearchForm bookSearchForm = new BookSearchForm("Title");
            bookSearchForm.ShowDialog();
        }

        private void openSearchAuth()
        {
            BookSearchForm bookSearchForm = new BookSearchForm("Author");
            bookSearchForm.ShowDialog();
        }

        private void MainUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void MainUserForm_Load(object sender, EventArgs e)
        {
            label2.Text = user.getName();

            transactionGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            transactionGridView.Columns[1].Width = 80;
        }
    }
}
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
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
            /*
            CustomFont cf = new CustomFont();
            cf.useExtraBold(label1);
            cf.useRegular(label2);
            cf.useRegular(label3);
            cf.useRegular(confirmBtn);
            */

            MyLibraryDb db = new MyLibraryDb();

            DataSet bookDs = new DataSet();
            DataSet userDs = new DataSet();

            string userSql = "SELECT user_id AS UserID, CONCAT(first_name, ' ', last_name) AS Name FROM user;";
            string bookSql = "SELECT isbn AS ISBN, title AS Title FROM books;";
            MySqlDataAdapter bookDa = new MySqlDataAdapter(bookSql, db.connection);
            MySqlDataAdapter userDa = new MySqlDataAdapter(userSql, db.connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(bookDa);
            MySqlCommandBuilder cb1 = new MySqlCommandBuilder(userDa);

            bookDa.Fill(bookDs, "books");
            userDa.Fill(userDs, "user");

            bookGridView.DataSource = bookDs;
            bookGridView.DataMember = "books";
            userGridView.DataSource = userDs;
            userGridView.DataMember = "user";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            bookGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            userGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            bookGridView.Columns[0].Width = 100;
            userGridView.Columns[0].Width = 50;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = isbnBox.Text;
                int user_id = Int32.Parse(userIdBox.Text);
                if (
                    isbnBox.TextLength < 1 || userIdBox.TextLength < 1
                    )
                {
                    MessageBox.Show("Failed: Check Input Again!");
                }
                else
                {
                    MyLibraryDb db = new MyLibraryDb();

                    if (!User.isUserIdExist(db, user_id) || !Book.isIsbnExist(db, isbn))
                    {
                        MessageBox.Show("Failed: Wrong User ID or ISBN");
                    }
                    else
                    {
                        string sql = "SET FOREIGN_KEY_CHECKS=0; INSERT INTO `transaction` (`transaction_id`, `user_id`, `isbn`, `borrow_date`, `return_date`) VALUES (NULL, ?user_id, ?isbn, ?borrow_date, ?return_date);";
                        try
                        {
                            db.connection.Open();
                            MySqlCommand command = db.connection.CreateCommand();
                            command.CommandText = sql;
                            user_id = Int32.Parse(userIdBox.Text);
                            command.Parameters.Add("?user_id", MySqlDbType.Int32).Value = user_id;
                            command.Parameters.Add("?isbn", MySqlDbType.VarChar).Value = isbn;
                            command.Parameters.Add("?borrow_date", MySqlDbType.Date).Value = DateTime.Now;
                            command.Parameters.Add("?return_date", MySqlDbType.Date).Value = DateTime.Now.AddDays(7);

                            command.ExecuteNonQuery();
                            db.connection.Close();

                            userIdBox.Text = "";
                            isbnBox.Text = "";

                            MessageBox.Show("Transaction Success");


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Transaction Error: " + ex.ToString());
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed: Invalid User ID");
            }
        }
    }
}

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
    public partial class ReturnBookForm : Form
    {
        MyLibraryDb db = new MyLibraryDb();
        Transaction transaction;

        public ReturnBookForm()
        {
            InitializeComponent();

            
            


            
        }

        private void updateGridView()
        {
            summaryPanel.Visible = false;

            DataSet transDs = new DataSet();
            string sql = "SELECT transaction.transaction_id AS ID, CONCAT(user.first_name, ' ', user.last_name) AS Name, books.isbn AS ISBN, books.title AS Title " +
                "FROM transaction " +
                "INNER JOIN user ON transaction.user_id = user.user_id " +
                "INNER JOIN books ON transaction.isbn = books.isbn;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

            adapter.Fill(transDs, "transaction");

            transactionGrid.DataSource = null;
            transactionGrid.Columns.Clear();

            transactionGrid.DataSource = transDs;
            transactionGrid.DataMember = "transaction";

            transactionGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            transactionGrid.Columns[0].Width = 30;
            transactionGrid.Columns[1].Width = 100;
            transactionGrid.Columns[2].Width = 90;
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (idBox.TextLength < 1)
            {
                summaryPanel.Visible = false;
                MessageBox.Show("Failed: Check input again");
                
            }
            else
            {
                try
                {
                    int id = Int32.Parse(idBox.Text);
                    if (!Transaction.isIdExist(db, id))
                    {
                        summaryPanel.Visible = false;
                        MessageBox.Show("Transaction ID not found");
                        
                    }
                    else
                    {
                        try
                        {
                            transaction = new Transaction(Transaction.getTransactionData(db, id));
                            userIdLabel.Text = transaction.user_id.ToString();
                            userNameLabel.Text = transaction.user_name;
                            isbnLabel.Text = transaction.isbn;
                            titleLabel.Text = transaction.title;
                            lateByLabel.Text = (transaction.isLate) ? transaction.lateBy.ToString() + " Days" : "Not Late";
                            penaltyLabel.Text = (transaction.isLate) ? "Rp " + transaction.penalty.ToString() : "-";

                            summaryPanel.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            summaryPanel.Visible = false;
                            MessageBox.Show("Error: " + ex.ToString());
                            
                        }
                    }
                }
                catch
                {
                    summaryPanel.Visible = false;
                    MessageBox.Show("Invalid ID Input!");
                    
                }
                
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM transaction WHERE transaction_id = " + transaction.id.ToString();
                db.connection.Open();
                MySqlCommand command = db.connection.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                db.connection.Close();

                MessageBox.Show("Transaction Success");
                summaryPanel.Visible = false;

                updateGridView();
            }
            catch
            {
                MessageBox.Show("Transaction Failed");
            }
        }
    }
}

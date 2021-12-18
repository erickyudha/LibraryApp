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
    public partial class BookAuditForm : Form
    {
        /*
        MySqlDataAdapter adapter;
        DataSet ds = new DataSet();
        */
        DataSet bookDs = new DataSet();
        DataSet authDs = new DataSet();
        DataSet pubDs = new DataSet();
        MySqlDataAdapter bookDa;
        MySqlDataAdapter authDa;
        MySqlDataAdapter pubDa;

        public BookAuditForm()
        {
            InitializeComponent();
            /*
            CustomFont cf = new CustomFont();

            cf.useSemiBold(label1);
            cf.useSemiBold(label2);
            cf.useSemiBold(label3);
            cf.useRegular(updateBtn);
            */

            try
            {
                MyLibraryDb db = new MyLibraryDb();
                string bookSql = "SET FOREIGN_KEY_CHECKS=0; SELECT isbn AS ISBN, title AS Title, author_ID AS AuthorID, publisher_id AS PublisherID, publish_year AS Year, description AS Description FROM books;";
                string authSql = "SET FOREIGN_KEY_CHECKS=0; SELECT author_id AS ID, name AS Name FROM authors;";
                string pubSql = "SET FOREIGN_KEY_CHECKS=0; SELECT publisher_id AS ID, name AS Name FROM publishers;";

                bookDa = new MySqlDataAdapter(bookSql, db.connection);
                authDa = new MySqlDataAdapter(authSql, db.connection);
                pubDa = new MySqlDataAdapter(pubSql, db.connection);

                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(bookDa);
                MySqlCommandBuilder cb2 = new MySqlCommandBuilder(authDa);
                MySqlCommandBuilder cb3 = new MySqlCommandBuilder(pubDa);

                bookDa.Fill(bookDs, "books");
                authDa.Fill(authDs, "authors");
                pubDa.Fill(pubDs, "publishers");

                bookGrid.DataSource = bookDs;
                bookGrid.DataMember = "books";
                authorGrid.DataSource = authDs;
                authorGrid.DataMember = "authors";
                publisherGrid.DataSource = pubDs;
                publisherGrid.DataMember = "publishers";

                /*
                string sql = "SET FOREIGN_KEY_CHECKS=0; SELECT isbn AS ISBN, title AS Title, author_ID AS AuthorID, publisher_id AS PublisherID, publish_year AS Year, description AS Description FROM books; " +
                    "SELECT author_id AS ID, name AS Name FROM authors; " +
                    "SELECT publisher_id AS ID, name AS Name FROM publishers;";
                adapter = new MySqlDataAdapter(sql, db.connection);
                adapter.TableMappings.Add("table", "books");
                adapter.TableMappings.Add("table1", "authors");
                adapter.TableMappings.Add("table2", "publishers");

                adapter.Fill(ds);

                bookGrid.DataSource = ds;
                bookGrid.DataMember = "table";
                authorGrid.DataSource = ds;
                authorGrid.DataMember = "table1";
                publisherGrid.DataSource = ds;
                publisherGrid.DataMember = "table2";
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                adapter.UpdateCommand = new MySqlCommandBuilder(adapter).GetUpdateCommand();
                adapter.DeleteCommand = new MySqlCommandBuilder(adapter).GetDeleteCommand();
                adapter.InsertCommand = new MySqlCommandBuilder(adapter).GetInsertCommand();
                adapter.Update(ds);
                */
                bookDa.Update(bookDs, "books");
                authDa.Update(authDs, "authors");
                pubDa.Update(pubDs, "publishers");

                MessageBox.Show("Update Database Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.ToString());
            }
            finally
            {
                this.Close();
            }
        }

        private void BookAuditForm_Load(object sender, EventArgs e)
        {
            bookGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            bookGrid.Columns[0].Width = 90;
            bookGrid.Columns[1].Width = 150;
            bookGrid.Columns[2].Width = 40;
            bookGrid.Columns[3].Width = 40;
            bookGrid.Columns[4].Width = 40;

            authorGrid.Columns[0].Width = 30;
            publisherGrid.Columns[0].Width = 30;
            


        }
    }
}

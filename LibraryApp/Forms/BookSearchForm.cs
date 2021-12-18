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
    public partial class BookSearchForm : Form
    {
        private string searchType;

        public BookSearchForm(string searchType)
        {
            this.searchType = searchType;
            
            InitializeComponent();

            searchLabel.Text = "Search " + searchType;

            /*
            CustomFont cf = new CustomFont();

            
            cf.useSemiBold(searchLabel);
            cf.useRegular(searchBtn);
            */
            try
            {
                DataSet bookDs = new DataSet();
                MyLibraryDb db = new MyLibraryDb();
                string sql = "SELECT books.isbn AS ISBN, books.title AS Title, authors.name AS Author, publishers.name AS Publisher, books.publish_year AS Year, books.description AS Description FROM books INNER JOIN authors ON books.author_id = authors.author_id INNER JOIN publishers ON books.publisher_id = publishers.publisher_id;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adapter);

                adapter.Fill(bookDs, "books");

                catalogGrid.DataSource = bookDs;
                catalogGrid.DataMember = "books";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BookSearchForm_Load(object sender, EventArgs e)
        {
            catalogGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            catalogGrid.Columns[0].Width = 90;
            catalogGrid.Columns[1].Width = 150;
            catalogGrid.Columns[2].Width = 90;
            catalogGrid.Columns[3].Width = 100;
            catalogGrid.Columns[4].Width = 40;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string srcStr = searchBox.Text;

                string sql;
                DataSet bookDs = new DataSet();
                MyLibraryDb db = new MyLibraryDb();
                if (searchType == "Title")
                {
                    sql = "SELECT books.isbn AS ISBN, books.title AS Title, authors.name AS Author, publishers.name AS Publisher, books.publish_year AS Year, books.description AS Description FROM books INNER JOIN authors ON books.author_id = authors.author_id INNER JOIN publishers ON books.publisher_id = publishers.publisher_id " +
                        "WHERE books.title LIKE '%" + srcStr + "%';";
                }
                else
                {
                    sql = "SELECT books.isbn AS ISBN, books.title AS Title, authors.name AS Author, publishers.name AS Publisher, books.publish_year AS Year, books.description AS Description FROM books INNER JOIN authors ON books.author_id = authors.author_id INNER JOIN publishers ON books.publisher_id = publishers.publisher_id " +
                        "WHERE authors.name LIKE '%" + srcStr + "%';";
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adapter);

                adapter.Fill(bookDs, "books");

                catalogGrid.DataSource = bookDs;
                catalogGrid.DataMember = "books";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}

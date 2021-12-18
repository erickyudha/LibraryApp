using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;
using MySql.Data;

namespace LibraryApp.Classes
{
    public abstract class Person
    {
        private string username;
        private string password;
        private string name;

        protected Person(DataSet dataSet)
        {
            this.username = dataSet.Tables[0].Rows[0][1].ToString();
            this.password = dataSet.Tables[0].Rows[0][2].ToString();
            this.name = dataSet.Tables[0].Rows[0][3].ToString() + " " + dataSet.Tables[0].Rows[0][4].ToString();
        }

        public string getName()
        {
            return name;
        }

        public bool verifyPass(string password)
        {
            return (this.password == password);
        }

        
    }
}

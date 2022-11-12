using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_SQL
{
    class Employee
    {
        public void CreateDatabase()
        {
            try
            {
                //sqlconnection makes a connection with the database
                //datasource-servername
                SqlConnection connection = new SqlConnection(@"Data Source=RAMYA\MSSQLSERVER01;Initial Catalog=master;Integrated Security=true");
                connection.Open();
                //sqlcommand is used to excute the sql statements
                SqlCommand cmd = new SqlCommand("Create database Employee", connection);
                //executenonquery is used to excute the sql queries
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee database created succesfully");
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }

    }
}


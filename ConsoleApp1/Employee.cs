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

        public SqlConnection connection = new SqlConnection(@"Data Source=RAMYA\MSSQLSERVER01;Initial Catalog=Employee;Integrated Security=true");
        public void CreateTable()
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("Create Table Employeedata(Empid int identity(1,1)primary key,Empname varchar(200),Salary varchar(200),Age int)", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee table is created successfully");
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void InsertRecord(string name, string salary, int age)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into Employeedata values ('" + name + "','" + salary + "','" + age + "')", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserted Record successfully");
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Delete(string name)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from Employeedata where Empname='" + name + "'", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Deleted successfully");
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void Retrivedata()
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from Employeedata", connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var id = Convert.ToInt32(sdr["Empid"]);
                    string name = (string)sdr["Empname"];
                    string salary = (string)sdr["Salary"];
                    int age = (int)Convert.ToInt64(sdr["Age"]);

                    Console.Write("Empid=" + id + "|" + "Empname=" + name + "|" + "Salary=" + salary + "|" + "Age=" + age);

                }
                Console.WriteLine("Record Retrived Sucessfully");
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void UpdateTheData(string name,string salary)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("update Employeedata set salary='"+salary+"'where Empname='"+name+"'", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Updated Sucessfully");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}


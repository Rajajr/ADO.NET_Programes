using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            while (true)
            {
                Console.WriteLine("Welcome To The Programe");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1:Crete a database\n2:Create a Table");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Enter the Number To Select Programe");
               
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------");

                switch (choice)
                {
                    case 1:
                        employee.CreateDatabase();

                        break;
                    case 2:
                        employee.CreateTable();
                        break;
                }
                Console.ReadLine();

            }
        }
    }
}

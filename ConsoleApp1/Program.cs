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
                Console.WriteLine("1:Crete a database\n2:Create a Table\n3:Insert The Records\n4:Delete particular Records\n5:Retrieve The Records\n6:Update The Record");
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

                    case 3:

                        Console.WriteLine("Enter the First Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the Salary");
                        string salary = Console.ReadLine();
                        Console.WriteLine("Enter the Age");
                        int age = Convert.ToInt32(Console.ReadLine());

                        employee.InsertRecord(name, salary, age);
                        break;

                    case 4:
                        Console.WriteLine("Enter the Name First");
                        string name1 = Console.ReadLine();
                        employee.Delete(name1);
                        break;

                    case 5:
                        employee.Retrivedata();
                        break;

                    case 6:
                        Console.WriteLine("Enter the First Name");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Enter the Salary");
                        string salary2 = Console.ReadLine();

                        employee.UpdateTheData(name2, salary2);
                        break;

                    default:
                        Console.WriteLine("Enter the Number Within Range");
                        break;
                }
                Console.ReadLine();

            }
        }
    }
}

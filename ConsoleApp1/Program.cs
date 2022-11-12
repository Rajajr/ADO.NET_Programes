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
                
                Console.WriteLine("1:Crete a database");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employee.CreateDatabase();

                        break;
                    
                }
                Console.ReadLine();

            }
        }
    }
}

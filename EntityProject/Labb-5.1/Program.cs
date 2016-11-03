using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Labb_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {employeeID = 1, name = "Anna", hireDate = DateTime.Parse("1994-10-12") },

                new Employee {employeeID = 1, name = "Kalle", hireDate = DateTime.Parse("2016-04-06") },

                new Employee {employeeID = 1, name = "Pelle", hireDate = DateTime.Parse("1998-03-12") },

                new Employee {employeeID = 1, name = "Sven", hireDate = DateTime.Parse("1855-08-28") },

                new Employee {employeeID = 1, name = "Jörgen", hireDate = DateTime.Parse("1866-12-31") },

                new Employee {employeeID = 1, name = "Sten", hireDate = DateTime.Parse("1542-02-04") }
            };

            IEnumerable<Employee> query = (from e in employees 
                                           where e.hireDate < DateTime.Parse("1990-10-20")
                                           orderby e.name
                                           select e);

             


            foreach (var employee in query)
            {
                Console.WriteLine($"Name: {employee.name} \nHireDate: {employee.hireDate}\n");
            }
            Console.ReadKey();

        }

        //public IEnumerable<string> result (IEnumerable<Employee> query)
        //{
        //     //return from t in Assembly.Load(query).GetType()
        //     //        where t is public
        //     //        select t.FullName;
                     
        // }
    }
}

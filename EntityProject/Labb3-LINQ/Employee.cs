using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_LINQ
{
    class Employee
    {
        public int empID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime hireDate { get; set; }
        public string department { get; set; }
        public int age { get; set; }

        List<Employee> employees = new List<Employee>();

        public void Menu ()
        {
            employees.Add(new Employee() { empID=1, fname = "Gopala", lname = "Johanesson", hireDate = DateTime.Now, department = "A", age = 22  } );
            employees.Add(new Employee() { empID = 1, fname = "Shelah", lname = "Peterson", hireDate = DateTime.Now, department = "B", age = 51 });
            employees.Add(new Employee() { empID = 1, fname = "Naveed", lname = "Gonzales", hireDate = DateTime.Now, department = "C", age = 24 });
            employees.Add(new Employee() { empID = 1, fname = "Nosson", lname = "Ramon", hireDate = DateTime.Now, department = "A", age = 21 });

            employees.Add(new Employee() { empID = 1, fname = "Hartley", lname = "Smith", hireDate = DateTime.Now, department = "B", age = 57 });
            employees.Add(new Employee() { empID = 1, fname = "Vilhelm", lname = "Svensson", hireDate = DateTime.Now, department = "D", age = 45 });
            employees.Add(new Employee() { empID = 1, fname = "Jorge", lname = "Olsson", hireDate = DateTime.Now, department = "D", age = 43 });
            employees.Add(new Employee() { empID = 1, fname = "Gaius", lname = "Stein", hireDate = DateTime.Now, department = "C", age = 37 });
           
            while (true)
            {
                Console.WriteLine("Menu ---------------------\n\n[1]Visa alla namn soretrade efter Efternamn\n[2]Visa alla namn sorterade efter Förnamn\n[3]Lista alla	employees för en viss avdelning\n[4]Sök ");
                int menuInput = int.Parse(Console.ReadLine());

                switch (menuInput)
                {
                    case 1:
                        var showListSortedByLname = employees.OrderBy(e => e.lname).ToList();
                        foreach (var e in showListSortedByLname)
                        {
                            Console.WriteLine($"{e.lname} {e.fname}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        var showListSortedByFname = employees.OrderBy(e => e.fname).ToList();
                        foreach (var e in showListSortedByFname)
                        {
                            Console.WriteLine($"{e.fname} {e.lname}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        var showListSortedByDepartment = employees.OrderBy(e => e.department).ToList();
                        foreach (var e in showListSortedByDepartment)
                        {
                            Console.WriteLine($"{e.fname} {e.lname} |Deparment: {e.department}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("Search: ");
                        string search = Console.ReadLine();
                        var searchList = employees.Where(e => e.fname.ToLower().Contains(search.ToLower()));
                        foreach (var e in searchList)
                        {
                            Console.WriteLine($"{e.fname} {e.lname}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }
            }
            



        }
    }
}

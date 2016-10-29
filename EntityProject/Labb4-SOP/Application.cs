using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_SOP
{
    class Application
    {
        public void Menu ()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { empID = 1, fname = "Gopala", lname = "Johanesson", hireDate = DateTime.Today.AddDays(-120), department = "A", age = 22 });
            employees.Add(new Employee() { empID = 2, fname = "Shelah", lname = "Peterson", hireDate = DateTime.Today.AddDays(-60), department = "B", age = 51 });
            employees.Add(new Employee() { empID = 3, fname = "Naveed", lname = "Gonzales", hireDate = DateTime.Today.AddDays(-30), department = "C", age = 24 });
            employees.Add(new Employee() { empID = 4, fname = "Nosson", lname = "Ramon", hireDate = DateTime.Today.AddDays(-312), department = "A", age = 21 });

            employees.Add(new Employee() { empID = 5, fname = "Hartley", lname = "Smith", hireDate = DateTime.Today.AddDays(-515), department = "B", age = 57 });
            employees.Add(new Employee() { empID = 6, fname = "Vilhelm", lname = "Svensson", hireDate = DateTime.Today.AddDays(-621), department = "D", age = 45 });
            employees.Add(new Employee() { empID = 7, fname = "Jorge", lname = "Olsson", hireDate = DateTime.Today.AddDays(-65), department = "D", age = 43 });
            employees.Add(new Employee() { empID = 8, fname = "Gaius", lname = "Stein", hireDate = DateTime.Today.AddDays(-12), department = "C", age = 37 });

            while (true)
            {
                Console.WriteLine("\nMenu ---------------------\n\n[1]Visa alla namn soretrade efter Efternamn\n[2]Visa alla namn sorterade efter Förnamn\n[3]Lista alla	employees för en viss avdelning\n[4]Sök \n[5]Hiredate less than one year \n[6]Show first person in the list in search of department");
                int menuInput = int.Parse(Console.ReadLine()); 

                switch (menuInput)
                {
                    case 1:
                        ListHelper.showListSortedByLname(employees);
                        Console.ReadKey();
                        break;
                    case 2:
                        ListHelper.showListSortedByFname(employees);
                        Console.ReadKey();
                        break;
                    case 3:
                        ListHelper.showListSortedByDepartment(employees);
                        Console.ReadKey();
                        break;
                    case 4:
                        ListHelper.Search(employees);
                        Console.ReadKey();
                        break;
                    case 5:
                        ListHelper.ShowListUnder1YearHireDate(employees);
                        Console.ReadKey();
                        break;
                    case 6:
                        ListHelper.FirstPersonInListDepartment(employees);
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("!!!!! Invalid choose, try again !!!!!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            
        }
    }
}

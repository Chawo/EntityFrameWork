using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_SOP
{
    public static class ListHelper
    {
        public static List<Employee> showListSortedByLname(List<Employee> employees)
        {
            var SortedByLnames = employees.OrderBy(e => e.lname).ToList();
            foreach (var e in SortedByLnames)
            {
                Console.WriteLine($"{e.fname} {e.lname}");
            }

            return SortedByLnames;
             
        }

        public static List<Employee> showListSortedByFname(List<Employee> employees)
        {
            var SortedByFnames = employees.OrderBy(e => e.fname).ToList();
            foreach (var e in SortedByFnames)
            {
                Console.WriteLine($"{e.fname} {e.lname}");
            }
            return SortedByFnames;
        }

        public static List<Employee> showListSortedByDepartment(List<Employee> employees)
        {
            var SortedByDepartment = employees.OrderBy(e => e.department).ToList();
            foreach (var e in SortedByDepartment)
            {
                Console.WriteLine($"{e.fname} {e.lname} \nDeparment: {e.department}\n");
            }
            return SortedByDepartment;
        }

        public static List<Employee> Search(List<Employee> employees)
        {
            Console.Write("Search: ");
            string search = Console.ReadLine();
            var searchList = employees.Where(e => e.fname.ToLower().Contains(search.ToLower()));
            foreach (var e in searchList)
            {
                Console.WriteLine($"{e.fname} {e.lname}");
            }
            return searchList as List<Employee>;
        }

        public static List<Employee> ShowListUnder1YearHireDate(List<Employee> employees)
        {
            DateTime today = DateTime.Today;
            var showJunior = employees.Where(e => (today - e.hireDate).Days < 365);
            foreach (var e in showJunior)
            {
                Console.WriteLine($"{e.fname} {e.lname} \nHiredate: {e.hireDate.ToShortDateString()}\n");
            }
            return showJunior as List<Employee>;
        }
        public static List<Employee> FirstPersonInListDepartment(List<Employee> employees)
        {
            var showFirstEmp = employees.Where(e => e.department == "A").FirstOrDefault();
            Console.WriteLine($"{showFirstEmp.fname} {showFirstEmp.lname} | {showFirstEmp.department} \n");

            Console.WriteLine("--------------------------\nList of Department");
            var listOfDepartment = employees.Where(d => d.department.FirstOrDefault() == 'A');
            foreach (var e in listOfDepartment)
            {
                Console.WriteLine($"{e.fname} {e.lname} | Department: {e.department}");

            }
            return listOfDepartment as List<Employee>;
        }

    }
}

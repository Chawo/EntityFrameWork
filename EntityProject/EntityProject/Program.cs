using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace EntityProject
{
    class Program 
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolEntities1())
            {
                Student student = new Student()
                {
                    fname = "Katrina",
                    lname = "Rosales",
                    gender = false,
                    grade = "A",
                    birthdate = DateTime.Now.AddYears(-45)
                };

                // Sparat bara i minnet
                ctx.Student.Add(student);
                // Här sparas det i databasen
                ctx.SaveChanges();
            }
        }
    }
}

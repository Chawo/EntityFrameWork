using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School())
            {
                Student ss = new Student()
                {
                    studentID = 11,
                    firstMidName ="Kalle",
                    lastName ="Anka",
                    enrollment = DateTime.Parse("1990-10-22")
                };

                ctx.Students.Add(ss);
                ctx.SaveChanges();


                foreach (var s in ctx.Students)
                {
                    Console.WriteLine($"\n--------------------------------------\nID: {s.studentID} \nFirstname: {s.firstMidName} \nLastname: {s.lastName}  ");
                    foreach (var e in ctx.Enrollments)
                    {
                        if (e.studentID != s.studentID)
                        {
                            Console.WriteLine($"\nID: {e.enrollmentID} \nName: {e.enrollmentName} \nGrade: {e.grade}");

                        }
                    }
                   
                     
                }
                Console.ReadKey();


            }

        }
    }
}

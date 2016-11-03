using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School())
            {
                foreach (var s in ctx.Students)
                {
                    Console.WriteLine($"\n--------------------------------------\nID: {s.studentID} \nFirstname: {s.firstMidName} \nLastname: {s.lastName}  ");
                    foreach (var e in s.enrollments)
                    {
                        Console.WriteLine($"\nID: {e.enrollmentID} \nName: {e.enrollmentName} \nGrade: {e.grade}");

                        if (e.studentID == s.studentID)
                        {
                            Console.WriteLine($"\nID: {e.enrollmentID} \nName: {e.enrollmentName} \nGrade: {e.grade}");

                        }
                    }
                    Console.ReadKey();
                }

            }
        }
    }
}
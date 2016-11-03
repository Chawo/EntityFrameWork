using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _4._3CRUDmotEntityFrameWork
{
    static class ListHelper
    {
        public static void ShowAllAuthors()
        {
            using (var ctx = new Books1Entities())
            {
                foreach (var a in ctx.Authors)
                {
                    Console.WriteLine($"{a.FirstName} {a.LastName}\nID: {a.AuthorID}");
                }
            }
        }

        public static void SearchFLname(string searchInput)
        {
            using (var ctx = new Books1Entities())
            { 
                var search = ctx.Authors.Where(x => x.FirstName.ToLower().ToUpper().StartsWith(searchInput) || x.LastName.ToLower().ToUpper().StartsWith(searchInput));
                foreach (var a in search)
                {
                    Console.WriteLine($"{a.FirstName} {a.LastName}");
                }
            }
        }

        public static void SearchAuthorsByID(int searchInput)
        {
            using (var ctx = new Books1Entities())
            { 
                var search = ctx.Authors.Where(x => x.AuthorID == searchInput);
                foreach (var a in search)
                {
                    Console.WriteLine($"Result:\nID: {a.AuthorID}\nAuthor: {a.FirstName} {a.LastName}");
                }

            }
        }

        public static void AddANewAuthour(int authorID, string fname, string lname, string homeTel, int paymentMethod, DateTime date)
        {
            using (var ctx = new Books1Entities())
            { 
                Authors author = new Authors()
                {
                    AuthorID = authorID,
                    FirstName = fname,
                    LastName = lname,
                    HomeTel = homeTel,
                    PaymentMethod = paymentMethod,
                    Age = date
                };

                ctx.Authors.Add(author);
                ctx.SaveChanges();
            }

        }

        public static void UpdateAuthoursName(string searchAuthorFname, string searchAuthorLname)
        {
            using (var ctx = new Books1Entities())
            { 
                var searchAuthorNameToUpdate = ctx.Authors.Where(x => x.FirstName.ToUpper().ToLower().Contains(searchAuthorFname) && x.LastName.ToUpper().ToLower().Contains(searchAuthorLname));

                foreach (var a in searchAuthorNameToUpdate)
                {
                    int countList = searchAuthorNameToUpdate.Count();
                    if (countList > 1)
                    {
                        Console.WriteLine($"Result: There are {countList} with the same name \nID: {a.AuthorID}\nAuthor: {a.FirstName} {a.LastName}");

                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Result:\nID: {a.AuthorID}\nAuthor: {a.FirstName} {a.LastName}");

                    }

                }

                Console.WriteLine("Write the new Firstname: ");
                string newFname = Console.ReadLine();

                Console.WriteLine("Write the new Lastname: ");
                string newLname = Console.ReadLine();

                searchAuthorNameToUpdate.FirstOrDefault().FirstName = newFname;
                searchAuthorNameToUpdate.FirstOrDefault().LastName = newLname;

                ctx.SaveChanges();



            }
        }

        public static void DeleteAAuthour(int deleteAuthour)
        {
            using (var ctx = new Books1Entities())
            { 
                var delete = (from a in ctx.Authors
                              where a.AuthorID == deleteAuthour
                              select a).FirstOrDefault();

                ctx.Authors.Remove(delete);
                ctx.SaveChanges();
            }
        }

        public static void UpdateAuthourAge(int updateAuthour)
        {
            using (var ctx = new Books1Entities())
            { 
                var updateAge = ctx.Authors.Where(a => a.AuthorID == updateAuthour).FirstOrDefault();
                try
                {
                    if (updateAge == null)
                    {
                        throw new Exception("Invalid ID, there's no ID in our Database");
                    }
                    Console.WriteLine("The new age: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    updateAge.Age = date;
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: " + e.ToString());
                    Console.ReadKey();
                    
                }

               





            }
        }

    }
}



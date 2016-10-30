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
            using (var ctx = new BooksEntities())
            {
                foreach (var a in ctx.Authors)
                {
                    Console.WriteLine($"{a.FirstName} {a.LastName}\nID: {a.AuthorID}");
                }
            }
        }

        public static void SearchFLname()
        {
            using (var ctx = new BooksEntities())
            {
                Console.WriteLine("Search (Firstname or Lastname)");
                string searchInput = Console.ReadLine();

                var search = ctx.Authors.Where(x => x.FirstName.ToLower().ToUpper().Contains(searchInput) || x.LastName.ToLower().ToUpper().Contains(searchInput));
                foreach (var a in search)
                {
                    Console.WriteLine($"{a.FirstName} {a.LastName}");
                }
            }
        }

        public static void SearchAuthorsByID()
        {
            using (var ctx = new BooksEntities())
            {
                Console.WriteLine("Search Authours by ID");
                int searchInput = int.Parse(Console.ReadLine());

                var search = ctx.Authors.Where(x => x.AuthorID == searchInput);
                foreach (var a in search)
                {
                    Console.WriteLine($"Result:\nID: {a.AuthorID}\nAuthor: {a.FirstName} {a.LastName}");
                }

            }
        }

        public static void AddANewAuthour()
        {
            using (var ctx = new BooksEntities())
            {
                Console.WriteLine("Firstname: ");
                string fname = Console.ReadLine();

                Console.WriteLine("LastName: ");
                string lname = Console.ReadLine();

                Console.WriteLine("HomeTel: ");
                string homeTel = Console.ReadLine();

                Console.WriteLine("PaymentMethod: ");
                int paymentMethod = int.Parse(Console.ReadLine());

                Authors author = new Authors()
                {
                    FirstName = fname,
                    LastName = lname,
                    HomeTel = homeTel,
                    PaymentMethod = paymentMethod
                };

                ctx.Authors.Add(author);
                ctx.SaveChanges();
            }

        }

        public static void UpdateAuthoursName()
        {
            using (var ctx = new BooksEntities())
            {
                Console.WriteLine("Write the Firstname of the Authour");
                string searchAuthorFname = Console.ReadLine();
                Console.WriteLine("Write the Lastname of the Authour");
                string searchAuthorLname = Console.ReadLine();

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

        public static void DeleteAAuthour()
        {
            using (var ctx = new BooksEntities())
            {

                Console.WriteLine("Write the ID for the Authour you want to delete.");
                int deleteAuthour = int.Parse(Console.ReadLine());

                var delete = (from a in ctx.Authors
                              where a.AuthorID == deleteAuthour
                              select a).FirstOrDefault();

                ctx.Authors.Remove(delete);
                ctx.SaveChanges();
            }
        }

        public static void UpdateAuthourAge()
        {
            using (var ctx = new BooksEntities())
            {

                Console.WriteLine("Write the ID for the Authour you want to update.");
                int updateAuthour = int.Parse(Console.ReadLine());

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



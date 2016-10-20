using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyMediaApp
{
    class Program 
    {
        static void Main(string[] args)
        {

            while (true)
            {
                using (var ctx = new Media())
                {
                    Console.WriteLine("[1] Add a new Book\n[2] Read \n[3] Update \n[4] Delete");
                int input = int.Parse(Console.ReadLine());
                     
                    switch (input)
                {
                    case 1:
                        
                            Console.WriteLine("Athour: ");
                            string author = Console.ReadLine();
                            Console.WriteLine("Title: ");
                            string title = Console.ReadLine();
                            //Console.WriteLine("ISBN: ");
                            //int isbn = int.Parse(Console.ReadLine());
                            Books newbook = new Books()
                            {
                                author = author,
                                title = title,
                                //isbn = isbn
                            };

                            CRUD create = new CRUD();
                            create.CreateBook(newbook);
                             
                         
                        break;
                    case 2:
                            Console.WriteLine("How much in the list ? : " + ctx.Books.Count());
                            foreach (var item in ctx.Books)
                            {
                                Console.WriteLine($"Author: {item.author} \nTitle: {item.title}\nISBN: {item.isbn} \n_________________________________\n");
                            }
                        break;
                    case 3:
                            Console.Write("Which one will you update, write the isbn? ");
                            int searchInput = int.Parse(Console.ReadLine());

                            var updateAuthor = (from a in ctx.Books
                                                where a.isbn == searchInput
                                                select a).FirstOrDefault();
                            Console.WriteLine("Write the new name of Author:");
                            string newUpdateAuthor = Console.ReadLine();
                            updateAuthor.author = newUpdateAuthor;
                            ctx.SaveChanges();
                             
                            break;
                    case 4:
                            Console.Write("Which one will you delete, write the isbn? ");
                            int searchdeleteInput = int.Parse(Console.ReadLine());

                            var bookToRemove = ctx.Books.SingleOrDefault(x => x.isbn == searchdeleteInput);
                            if (bookToRemove != null)
                            {
                                ctx.Books.Remove(bookToRemove);
                                ctx.SaveChanges(); 
                            }
                            break;
                }
                    Console.ReadKey();
                    //Console.Clear();

                }
            }

        }
    }
}

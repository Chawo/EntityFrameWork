using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3CRUDmotEntityFrameWork
{
    class Application
    {
        List<Authors> authors = new List<Authors>();

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Visa en lista på alla författare \n2. Search (Firstname or Lastname \n3. Search Authours by ID \n4. Lägg till en ny författare \n5. Update Author name \n6. Ta bort en Author");
                int userChoose = int.Parse(Console.ReadLine());

                switch (userChoose)
                {
                    case 1:
                        ListHelper.ShowAllAuthors();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Search (Firstname or Lastname)");
                        string searchInput = Console.ReadLine();
                        ListHelper.SearchFLname(searchInput);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Search Authours by ID");
                        int searchInputID = int.Parse(Console.ReadLine()); 
                        ListHelper.SearchAuthorsByID(searchInputID);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("ID: ");
                        int authorID = int.Parse(Console.ReadLine());

                        Console.WriteLine("Firstname: ");
                        string fname = Console.ReadLine();

                        Console.WriteLine("LastName: ");
                        string lname = Console.ReadLine();

                        Console.WriteLine("HomeTel: ");
                        string homeTel = Console.ReadLine();

                        Console.WriteLine("PaymentMethod: ");
                        int paymentMethod = int.Parse(Console.ReadLine());

                        Console.WriteLine("Age: ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        ListHelper.AddANewAuthour(authorID, fname, lname, homeTel, paymentMethod, date);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Write the Firstname of the Authour");
                        string searchAuthorFname = Console.ReadLine();
                        Console.WriteLine("Write the Lastname of the Authour");
                        string searchAuthorLname = Console.ReadLine();

                        ListHelper.UpdateAuthoursName(searchAuthorFname, searchAuthorLname);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Write the ID for the Authour you want to delete.");
                        int deleteAuthour = int.Parse(Console.ReadLine());
                        ListHelper.DeleteAAuthour(deleteAuthour);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Write the ID for the Authour you want to update.");
                        int updateAuthour = int.Parse(Console.ReadLine());
                        ListHelper.UpdateAuthourAge(updateAuthour);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}

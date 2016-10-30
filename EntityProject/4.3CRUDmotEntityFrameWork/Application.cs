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
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 2:
                        ListHelper.SearchFLname();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 3:
                        ListHelper.SearchAuthorsByID();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 4:
                        ListHelper.AddANewAuthour();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 5:
                        ListHelper.UpdateAuthoursName();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 6:
                        ListHelper.DeleteAAuthour();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 7:
                        ListHelper.UpdateAuthourAge();
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}

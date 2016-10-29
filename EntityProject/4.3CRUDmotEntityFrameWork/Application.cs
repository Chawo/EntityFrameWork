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
            Console.WriteLine("1. Visa en lista på alla författare \n2. Search (Firstname or Lastname \n3. Search Authours by ID \n4. Lägg till en ny författare \n5. Update Author name");
            int userChoose = int.Parse(Console.ReadLine());

            switch (userChoose)
            {
                case 1:
                    ListHelper.ShowAllAuthors();
                    Console.ReadKey();
                    break;
                case 2:
                    ListHelper.SearchFLname();
                    Console.ReadKey();
                    break;
                case 3:
                    ListHelper.SearchAuthorsByID();
                    Console.ReadKey();
                    break;
                case 4:
                    ListHelper.AddANewAuthour();
                    Console.ReadKey();
                    break;
                case 5:
                    ListHelper.UpdateAuthoursName();
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatoriskprojekt0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu\n-------------------------------\n\n[1]Register a new kund \n[2]Register a new movie \n[3]Remove customer \n[4]Remove movie \n[5]Hyra en film \n[5]Lämna tillbaka film");

            int userChoice = int.Parse(Console.ReadLine()); 
            MyMediaControls m = new MyMediaControls();

            switch (userChoice)
            {
                case 1: 
                    Console.WriteLine("Movie name: ");
                    string mName = Console.ReadLine();
                    Console.WriteLine("Director name: ");
                    string dName = Console.ReadLine();
                    Console.WriteLine("ReleaseDate [YYYY:MM:DD] : ");
                    DateTime releaseDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("GenreID: ");
                    int genreID = int.Parse(Console.ReadLine());

                    m.Addmovie(mName, dName, releaseDate, genreID);
                    break;
                case 2:
                    Console.WriteLine("Customer name: ");
                    string cName = Console.ReadLine();
                    Console.WriteLine("Customer Adress: ");
                    string cAdress = Console.ReadLine();
                    Console.WriteLine("Customer Phone: ");
                    string cPhone = Console.ReadLine();

                    m.AddCustomer(cName, cAdress, cPhone);
                    break;
                case 3:
                    Console.WriteLine("Which customer do you want to remove?");
                    int removeC = int.Parse(Console.ReadLine());
                    m.RemoveCustomer(removeC);
                    break;
                case 4:
                    m.ListOfMovie();
                    Console.WriteLine("Which movie do you want to remove?");
                    int removeM = int.Parse(Console.ReadLine());
                    m.RemoveMovie(removeM);
                    break;
                case 5:
                    m.ListOfMovie(); 
                    Console.WriteLine("Which movie do you want to rent?");
                    int customerMovieChoice = int.Parse(Console.ReadLine());
                    m.RentAMovie(customerMovieChoice);

                    break;
                case 6:
                    Console.WriteLine("What's your Customer ID");
                    int cID = int.Parse(Console.ReadLine());
                    m.ReturnMovie(cID);

                    break;
            }
        }
    }
}

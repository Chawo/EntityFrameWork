using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_LINQ
{
    class _3
    {
        List<string> persons = new List<string>(); 
        public void Menu()
        {
            persons.Add("Anna");
            persons.Add("Katrina");
            persons.Add("Pelle");
            persons.Add("Anisa");
            persons.Add("Krizia");
            persons.Add("Jesper");
            persons.Add("Alexandra");
            persons.Add("Kajsa");
            while (true)
            {
                Console.WriteLine("MENU\n\n[1] Visa alla namn\n[2] Visa alla namn som börjar på A \n[3] Visa alla namn som innehåller ett A \n[4] Visa alla namn som börjar på A och inte innehåller ett S");
                int UserInput = int.Parse(Console.ReadLine());
                switch (UserInput)
                {
                    case 1:
                        var personList = from person in persons
                                       select person;
                        foreach (var p in personList)
                        {
                            Console.WriteLine(p);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        
                    case 2:

                        var showPersonListStartWithA = from person in persons
                                                       where person.StartsWith("A") 
                                                       select person;

                        foreach (var p in showPersonListStartWithA)
                        {
                            Console.WriteLine(p); 
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break; 
                    case 3:
                        var personListWithA = persons.Where(p => p.ToUpper().Contains("A"));
                        foreach (var person in personListWithA)
                        {
                            Console.WriteLine(person);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4: 
                        var SearchPersonSA = persons.Where(n => n.ToUpper().StartsWith("A") && (!n.ToUpper().Contains("S")));

                        foreach (var p in SearchPersonSA)
                        {
                            Console.WriteLine(p);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
            
        }
    }
}

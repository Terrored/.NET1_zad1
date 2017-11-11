using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET1_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("Do Studzienki 27/1", 3, 4, 50);
            House house2 = new House("Miszewskiego 37/2", 7, 5, 70);
            House house3 = new House("Wojska Polskiego 150", 1, 8, 120);
            

            List<House> ListOfHouses = new List<House>();
            ListOfHouses.Add(house1);
            ListOfHouses.Add(house2);
            ListOfHouses.Add(house3);

            foreach (House house in ListOfHouses)
            {
                Console.WriteLine("*****************************************************************");
                Console.WriteLine(house.ToString());
            }
            

            Console.ReadKey();
            
        }
    }
}

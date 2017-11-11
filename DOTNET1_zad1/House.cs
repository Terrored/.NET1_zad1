using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET1_zad1
{
    class House
    {
       

        public string Adress { get; private set; }
        public int NumberOfMembers { get; private set; }

        public int NumberOfWindows { get; private set; }

        public double Area { get; private set; }

        public House(string adress, int numberOfMembers, int numberOfWindows, double area)
        {
            Adress = adress;
            NumberOfMembers = numberOfMembers;
            NumberOfWindows = numberOfWindows;
            Area = area;
        }

        public string Tax()
        {
            double tax;
            tax = Area * 10;
            return " Podatek od metrażu wynosi " + tax + " zł.";
        }

        public override string ToString()
        {
            return "Dom o adresie: " + Adress + ". Liczba okien: " + NumberOfWindows + ". Liczba członków rodziny: " + NumberOfMembers
                + ". Metraż wynosi: " + Area +" m2."+ Tax();
        }
    }
}

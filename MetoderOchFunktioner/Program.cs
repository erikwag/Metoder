using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOchFunktioner
{
    class Program
    {
        static void CelciusTillFarenheit(double Celcius)
        {
            Console.WriteLine((Celcius/5.0)*9+32 +" grader i Farenheit");
        }

        static double Omkrets(int radie)
        {

        }

        static double Area(int radie)
        {

        }

        static void Main(string[] args)
        { 
            //Övning1
            Console.Write("Skriv in grader i celcius ");
            double Celcius = double.Parse(Console.ReadLine());
            CelciusTillFarenheit(Celcius);

            //Övning2



        }
    }
}

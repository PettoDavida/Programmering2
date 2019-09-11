using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_W._36_37
{
    class Homework_1
    {
        public static void Main(string[] args)
        {
            nmr1();
            nmr2();
            
        }

        
        public static void nmr1()
        {

            Console.WriteLine("1. Skapa en metod som tar in ett okänt antal heltal och returnerar deras summa.");
            Console.WriteLine("Skriv heltal");
            Thread.Sleep(5000);

            Random intag = new Random();

            int random = intag.Next(1, 11);

            int intagna = 0;

            int tal;

            int summa = 0;

            while (intagna < random)
            {
                Console.WriteLine("skriv ett heltal");
                try
                {
                    tal = int.Parse(Console.ReadLine());
                } catch(Exception e)
                {
                    continue;
                }
                intagna++;
                summa += tal;
                
            }
            Console.WriteLine("Det totala är " + summa);
            Console.ReadLine();

        }

        public static void nmr2()
        {

        }
    }
}

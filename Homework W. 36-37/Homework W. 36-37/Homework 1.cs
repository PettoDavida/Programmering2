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
            //nmr1();
            //nmr2();
            object[] five = nmr3(1, 2, 3, 4, "hello", 3.14f, "fredrik");
            for (int i = 0; i < five.Length; i++)
            {
                Console.Write(five[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        
        public static void nmr1()
        {

            Console.WriteLine("1. Skapa en metod som tar in ett okänt antal heltal och returnerar deras summa.");
            Console.WriteLine("Skriv heltal");

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

        }

        public static void nmr2()
        {

            Console.WriteLine("2. Skapa en rekursiv metod som tar in en sträng och returnerar den baklänges.");
            Console.WriteLine("Skriv in ett ord och klicka enter om du skriver stop så stängs metoden av");

            string ord = Console.ReadLine();
            if (ord.ToLower() == "stop" )
            {
                return;
            }
            for (int i = ord.Length - 1; i >= 0; i--)
            {
                Console.Write(ord[i]);
            }
            Console.WriteLine();
            nmr2();
        }

        public static object[] nmr3(params object[] list)
        {
            Console.WriteLine("Skapa en generisk metod som tar in ett okänt antal objekt och returnerar en array av dem");
            return list;

        }
    }
}

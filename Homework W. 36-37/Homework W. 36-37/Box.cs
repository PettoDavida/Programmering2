using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_W._36_37
{
    class Box
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("4. Skapa en klass Box som tar in ett okänt antal objekt och lagrar dem.");
            Console.WriteLine();
        List<object> objekt = new List<object> { };
        Random rnd = new Random();
        int random = rnd.Next(1, 11);
            object obj;


            for (int i = 0; i < random; i++)
            {
                obj = Console.ReadLine();
                objekt.Add(obj);
            }

        }
    }
}

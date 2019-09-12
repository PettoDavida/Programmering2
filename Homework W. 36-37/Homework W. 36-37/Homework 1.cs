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
            int[] nummer = new int[10] {1, 3, 4, 5, 6,1,123,82,91,1000 };
            int summa = nmr1(nummer);
            
            Console.WriteLine(summa);
            
            string str = "Hello World";
            string reversedStr = nmr2(str);
            Console.WriteLine("Reverse: {0} -> {1}", str, reversedStr);
            object[] five = nmr3(1, 2, 3, 4, "hello", 3.14f, "fredrik");
            for (int i = 0; i < five.Length; i++)
            {
                Console.Write(five[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        
        public static int nmr1(int[] nummer )
        {
            int summa = 0;
            Console.WriteLine("1. Skapa en metod som tar in ett okänt antal heltal och returnerar deras summa.");
            for (int i = 0; i < nummer.Length; i++)
            {
                summa += nummer[i];
            }
            return summa;
        }

        public static string nmr2(string str)
        {

            if (str.Length <= 0)
                return str;

            return nmr2(str.Substring(1)) + str[0];
        }

        public static object[] nmr3(params object[] list)
        {
            Console.WriteLine("Skapa en generisk metod som tar in ett okänt antal objekt och returnerar en array av dem");
            return list;

        }

        public static void nmr4()
        {
            Console.WriteLine("4. Skapa en klass Box som tar in ett okänt antal objekt och lagrar dem.");
            Console.WriteLine();
            
        }
        public static void nmr5()
        {
            Box A = new Box("abc", "def");
            Box B = new Box(839, 213);
        }
    }
}

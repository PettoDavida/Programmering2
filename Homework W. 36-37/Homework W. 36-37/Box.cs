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
        public List<object> saker;

        public Box (params object[] list)
        {
            saker = new List<object>();

            foreach  (object item in list)
            {
                saker.Add(item);
            }
        }

        

        public void Metod()
        {
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

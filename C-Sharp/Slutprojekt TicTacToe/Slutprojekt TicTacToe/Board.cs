using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt_Poker
{
    class Board
    {
        private int[,] cells = new int[3, 3];
        public bool check(int x, int y)
        {
            int position = cells[x, y];
            return position > 0;
        }
    }
}

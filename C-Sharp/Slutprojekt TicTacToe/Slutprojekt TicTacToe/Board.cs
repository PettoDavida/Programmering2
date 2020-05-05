using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public void setValue(int x, int y, int v)
        {
            cells[x, y] = v;
        }

        public bool threeinarow(int player)
        {
            for (int y = 0; y < 3; y++)
            {
                if (cells[0, y] == player && cells[1, y] == player && cells[2, y] == player)
                {
                    return true;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                if (cells[x, 0] == player && cells[x, 1] == player && cells[x, 2] == player)
                {
                    return true;
                }
            }

            if (cells[0, 0] == player && cells[1, 1] == player && cells[2, 2] == player)
            {
                return true;
            }

            if (cells[0, 2] == player && cells[1, 1] == player && cells[2, 0] == player)
            {
                return true;
            }

            return false;
        }
    }
}

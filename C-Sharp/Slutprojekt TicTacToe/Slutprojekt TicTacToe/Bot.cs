using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt_Poker
{
    class Bot
    {
        private Board board;
        public Bot(Board board)
        {
            this.board = board;
        }
        public void botmove()
        {
            Random random = new Random();

            int x = random.Next(0, 3);

            int y = random.Next(0,3);

            if (x > 0)
            {

            }
        }
    }
}

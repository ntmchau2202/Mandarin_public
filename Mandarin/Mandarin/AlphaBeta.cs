/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandarin
{
    public class AlphaBeta
    {
        public int alphaBeta(Board square, int depth, int gamer, int alpha, int beta)
        {
            if (gamer == 1)
                square.spread(gamer);
            else if (gamer == 2)
                square.spread(gamer);

        }
        public ArrayList generateMoves(Board board, int gamer)
        {
            ArrayList result = new ArrayList();
            if (board.isFinish() == true)
            {
                return result;
            }
            if (gamer == 1)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (board[i] != 0)
                    {
                        result.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 7; i <=11; i++)
                {
                    if (board[i] != 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}*/

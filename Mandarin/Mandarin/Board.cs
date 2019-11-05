/*using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandarin
{
    public class Board
    {
        public Squares[] square = new Squares[12];

        public ArrayList result = new ArrayList();

        public Squares[] update(Squares[] squares)
        {
            Squares[] s = new Squares[squares.Length];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Squares(i, squares[i].getValue(), squares[i].checkKing());
            }
            return s;
        }


        public int moveLeft(int pos)
        {
            int value = square[pos].getValue();
            square[pos].setValue(0);
            while (value != 0)
            {
                pos++;
                if (pos == 12)
                {
                    pos = 0;
                }
                squares[pos].setValue(squares[pos].getValue() + 1);
                value--;
            }
            viTri++;
            if (viTri == 12)
            {
                viTri = 0;
            }
            if (squares[viTri].getValue() != 0 && viTri % 6 != 0)
            {
                return left(viTri);
            }
            else
            {
                return viTri--;
            }
        }

        public int moveRight(int pos)
        {
            while ((pos % 12) != 0)
            {
                int n = square[pos];
                square[pos] = 0;
                while (n > 0)
                {
                    pos++;
                    if (pos = 12) pos = 0;
                    square[pos]++;
                }
                if (square[pos+1] != 0) pos++;
            }
            return pos;
        }

        public bool canEatRight(int pos)
        {
            if (pos == 11 && square[0] == 0 && square[1]!=0) return true;
            
            else if (square[pos + 1] == 0 && square[pos + 2] != 0)
                return true;
            else return false;
        }

        public bool canEatLeft(int pos)
        {
            if (pos == 1 && square[0] == 0 && square[11]!=0) return true;
            if (square[pos - 1] == 0 && square[pos - 2] != 0)
                return true;
            else return false;
        }

        public void eatLeft(int pos, int gamer)
        {
            while(canEatLeft(pos)==true)
            {
                gamer += square[pos-2];
                square[pos - 2] = 0;
                pos -= 2;
            }
        }

        public void eatRight(int pos, int gamer)
        {
            while (canEatRight(pos) == true)
            {
                gamer += square[pos + 2];
                square[pos + 2] = 0;
                pos += 2;
            }
        }
        
        // kiem tra het game
        public bool isFinish()
        {
            if (square[0] == 0 && square[11] == 0)
                return true;
            else return false;
        }

        // cong diem khi het game
        public void sumScore(int gamer1, int gamer2)
        {
            if (isFinish()==true)
            {
                gamer1 = gamer1 + square[1] + square[2] + square[3] + square[4] + square[5];
                gamer2 = gamer2 + square[7] + square[8] + square[9] + square[10] + square[11];
            }
        }

        // hết quân nhưng vẫn còn quan
        public bool isManExist(int gamer)
        {
            int score = 0;

            if (gamer == 1)
            {
                for (int i = 1; i <= 5; i++)
                    score += square[i];
                if (score == 0) return false;
            }
            else if (gamer == 2)
            {
                for (int i = 7; i <= 10; i++)
                    score += square[i];
                if (score == 0) return false;
            }

            return true;
        }

        public void spread(int gamer)
        {
            if(isManExist(gamer)==false)
            {
                if(gamer==1)
                {
                    for (int i = 1; i <= 5; i++)
                        square[i]++;
                }
                else if(gamer==2)
                {
                    for (int i = 7; i <= 11; i++)
                        square[i]++;
                }
            }
        }
    } */

 /*   public class dynamicSquares : Squares
    {
        public void MoveLeft(dynamicSquares d)
        {
            int currentPos = d.num;
            for (int i = 1;i <= d.pebbel_num; i++)
            {

            }
        }
    }

}*/

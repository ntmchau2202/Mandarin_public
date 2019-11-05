using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandarin
{
    public class Squares
    {
        public int location;
        public int value;
        public bool isKing;

        public Squares(int location, int value, bool isKing)
        {
            this.location = location;
            this.value = value;
            this.isKing = isKing;
        }

        public int getValue()
        {
            return value;
        }
        
        public int getLocation()
        {
            return location;
        }

        public bool checkKing()
        {
            return isKing;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public void setLocation(int location)
        {
            this.location = location;
        }

        public void setKing(bool isKing)
        {
            this.isKing = isKing;
        }

    }
}

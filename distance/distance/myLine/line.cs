using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using distance.DL;

namespace distance.BL
{
    class MyPoint
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public MyPoint()
        {
           
        }
        public int getX()
        {

            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }

        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //public double distanceWithCords(int x, int y)
        //{

        //}

        //public double distanceWithObject(MyPoint another)
        //{

        //}

        public double distanceFromZero()
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));
            return distance;
        }

    }

}

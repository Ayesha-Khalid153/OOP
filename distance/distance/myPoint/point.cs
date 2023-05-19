using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using distance.BL;

namespace distance.DL
{
    class myLine
    {
        public MyPoint begin;
        public MyPoint end;

        public myLine()
        {
        }

        public myLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }


        public MyPoint getBegin()
        {
            return begin;
        }

        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }

        public MyPoint getEnd()
        {
            return end; ;
        }

        public void setEnd(MyPoint end)
        {
            this.end = end;
        }
       

        public double getLength()
        {
            double length = 0;
            length = Math.Sqrt(Math.Pow((end.x - begin.x), 2) + Math.Pow((end.y - begin.y), 2));
            return length;
        }

        public double getGradient()
        {
            double gradient = 0;
            gradient = (end.y - begin.y) / (end.x - begin.x);
            return gradient;
        }

    }
}
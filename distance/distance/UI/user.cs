using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using distance.BL;
using distance.DL;

namespace distance.UI
{
    class user
    {
        public static string menu()
        {
            string choice = null;

            Console.WriteLine("1.Make a Line");
            Console.WriteLine("2.Update the Begining Point");
            Console.WriteLine("3.Update the End Point");
            Console.WriteLine("4.Show begin Point");
            Console.WriteLine("5.Show End Point");
            Console.WriteLine("6.Get the Length of Line");
            Console.WriteLine("7.Get the Gradient of Line");
            Console.WriteLine("8.Find the distance of Begin Point from Zero Co-ordinate");
            Console.WriteLine("9.Find the distance of End Point from Zero Co-ordinate");
            Console.WriteLine("1.-Exit");
            choice = Console.ReadLine();

            return choice;
        }

        public static myLine _1making_Line()
        {
            Console.WriteLine("Enter the x1 coordiate : ");
            int X1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y1 coordiate : ");
            int Y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the x2 coordiate : ");
            int X2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y2 coordiate : ");
            int Y2 = int.Parse(Console.ReadLine());

            MyPoint begin_point = new MyPoint(X1,Y1);
            MyPoint end_point = new MyPoint(X2,Y2);
            myLine line = new myLine(begin_point, end_point);
            return line;
        }

        public static MyPoint _2update_begin()
        {
            Console.WriteLine("Enter the x1 coordiate : ");
            int X1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y1 coordiate : ");
            int Y1 = int.Parse(Console.ReadLine());

            MyPoint update_begin = new MyPoint(X1, Y1);
            return update_begin;
        }

        public static MyPoint _3update_end()
        {
            Console.WriteLine("Enter the x2 coordiate : ");
            int X2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y2 coordiate : ");
            int Y2 = int.Parse(Console.ReadLine());

            MyPoint update_end = new MyPoint(X2, Y2);
            return update_end;
        }

        public static void _4View_begin(myLine line)
        {
            Console.WriteLine("the starting point of the line is : (" + line.begin.x + "," + line.begin.y + ")" );

        }

        public static void _5View_end(myLine line)
        {
            Console.WriteLine("the starting point of the line is : (" + line.end.x + "," + line.end.y + ")" );

        }

        public static void _6Get_Line(myLine line)
        {
            Console.WriteLine("the starting point of the line is : (" + line.begin.x + "," + line.end.y + ")");
            Console.WriteLine("the ending point of the line is : (" + line.end.x + "," + line.end.y + ")" );
        }

        public static void _7Get_Gradient(myLine gradient)
        {
            Console.WriteLine("the gradient of the line is : " + gradient );
        }

        public static void _8distanec_From_begin(myLine distance_begin)
        {
            Console.WriteLine("the gradient of the line is : " + distance_begin);
        }

        public static void _9distanec_From_end(myLine distance_end)
        {
            Console.WriteLine("the gradient of the line is : " + distance_end);
        }


    }
}

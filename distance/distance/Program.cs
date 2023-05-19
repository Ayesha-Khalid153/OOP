using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using distance.BL;
using distance.DL;
using distance.UI;

namespace Line
{
    class Program
    {

        static void Main(string[] args)
        {
            myLine line = new myLine();
            MyPoint point = new MyPoint();
            string option = null;
            do
            {
                option = user.menu();
                if (option == "1")
                {
                    Console.Clear();
                    line = user._1making_Line();
                    user._6Get_Line(line);
                    Console.Clear();
                }

                if (option == "2")
                {
                    Console.Clear();
                    point = user._2update_begin();
                    user._4View_begin(line);
                    Console.Clear();
                }


                if (option == "3")
                {
                    Console.Clear();
                    point = user._3update_end();
                    user._5View_end(line);
                    Console.Clear();
                }


                if (option == "4")
                {
                    Console.Clear();
                    user._4View_begin(line);
                    Console.ReadKey();
                    Console.Clear();
                }


                if (option == "5")
                {
                    Console.Clear();
                    user._5View_end(line);
                }


                if (option == "6")
                {
                    Console.Clear();
                    user._6Get_Line(line);
                    Console.Clear();
                }


                if (option == "7")
                {
                    Console.Clear();
                    user._7Get_Gradient(line);
                    Console.Clear();
                }


                if (option == "8")
                {
                    Console.Clear();
                    user._8distanec_From_begin(line);
                    Console.Clear();
                }


                if (option == "9")
                {
                    Console.Clear();
                    user._9distanec_From_end(line);
                    Console.Clear();
                }


                if (option == "10")
                {
                    break;
                }

                Console.ReadKey();

            } while (option != "11");
        }
    }

    
}


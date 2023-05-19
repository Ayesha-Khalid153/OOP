using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.BL;
using shop.DL;
using shop.UI;

namespace shop
{
    class Program
    {

        List<MenuItem> a = new List<MenuItem>();

        static void Main(string[] args)
        {
            int va = 0;

            int option;
            do
            {
                string result;
                option = user.User_Menu();
                if (option == 1)
                {
                    Console.Clear();
                    MenuItem m = user.Add_Menu();
                    data.add_item_Info_InList(m);
                }
                if (option == 2)
                {
                    Console.Clear();
                    string n = data.viewCheapestItem();
                    Console.WriteLine("CHEAPEST ITEM IS: {0}", n)

                }
                if (option == 3)
                {
                    Console.Clear();
                    data.View_Drinks();
                }
                if (option == 4)
                {
                    Console.Clear();
                    data.View_Food();
                }
                if (option == 5)
                {
                    Console.Clear();
                    data.Order_Item();
                }
                if (option == 6)
                {
                    Console.Clear();
                    string naam = "";
                    va = data.fullFilled_Orders(naam);
                }
                if (option == 7)
                {
                    Console.Clear();
                    data.View_Order();
                }
                if (option == 8)
                {
                    Console.Clear();
                    data.View_Bill(va);
                }
                if (option == 9)
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (option != 10);

        }
    }
}

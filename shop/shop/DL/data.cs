using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.BL;

namespace shop.DL
{
    class data
    {

        public static void add_item_Info_InList(MenuItem i)
        {
            CoffeeShop.menu.Add(i);
        }
        public static void View_Drinks()
        {
            foreach (MenuItem b in CoffeeShop.menu)
            {
                if (b.Item_Type == "drink")
                {
                    Console.WriteLine("drinks in the store are : {0}", b.Item_Name);
                }
            }
        }

        public static void View_Food()
        {
            foreach (MenuItem b in CoffeeShop.menu)
            {
                if (b.Item_Type == "food")
                {
                    Console.WriteLine("Item with the type FOOD in store are : {0}", b.Item_Name);
                }
            }
        }


        public static void Order_Item()
        {
            //Console.WriteLine("Enter how many items you wanna order?");
            //int order_numbers = int.Parse(Console.ReadLine());
            //for (int i = 0; i < order_numbers; i++)
            //{
                Console.WriteLine("Enter the name  of the Item you want to buy : ");
                string Name = Console.ReadLine();
                foreach (MenuItem m in CoffeeShop.menu)
                {
                    if (m.Item_Name == Name)
                    {
                        CoffeeShop.Orders.Add(Name);
                    }
                    else
                    {
                        Console.WriteLine("This Item doesnot exist in the menu..");
                    }
                }
            //}
        }


        public static string viewCheapestItem()
        {
            int cheap = CoffeeShop.menu[0].Item_Price;
            string name = CoffeeShop.menu[0].Item_Name;
            foreach (MenuItem m in CoffeeShop.menu)
            {
                if (m.Item_Price < cheap)
                {
                    cheap = m.Item_Price;
                    name = m.Item_Name;
                }
            }
            return name;
        }

        public static int fullFilled_Orders(string name)
        {
            int total = 0;
            if (CoffeeShop.Orders != null)
            {
                for (int idx = 0; idx < CoffeeShop.Orders.Count; idx++)
                {
                    Console.WriteLine("THIS ITEM " + CoffeeShop.Orders[idx] + "IS READY ");
                    foreach (MenuItem o in CoffeeShop.menu)
                    {
                        if (CoffeeShop.Orders[idx] == o.Item_Name)
                        {
                            total = total + o.Item_Price;
                        }
                    }
                    CoffeeShop.Orders.Remove(CoffeeShop.Orders[idx]);
                }
            }
            else if (CoffeeShop.Orders == null)
            {
                Console.WriteLine("All orders have been fillfilled");
            }

            return total;
        }

        public static void View_Order()
        {
            foreach (string i in CoffeeShop.Orders)
            {
                Console.WriteLine(i);
            }
        }
        public static void View_Bill(int bill)
        {
            Console.WriteLine("Your total bill is : {0}", bill);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.BL;

namespace shop.UI
{
    class user
    {
        public static MenuItem Add_Menu()
        {
            Console.WriteLine("ENTER THE NAME OF ITEM: ");
            string Item_Name = Console.ReadLine();
            Console.WriteLine("ENTER THE TYPE OF ITEM: ");
            string Item_Type = Console.ReadLine();
            Console.WriteLine("ENTER THE PRICE OF ITEM: ");
            int Item_Price = int.Parse(Console.ReadLine());

            MenuItem item = new MenuItem(Item_Name, Item_Type, Item_Price);
            return item;
        }

        public static int User_Menu()
        {
            int option = 0;
            Console.WriteLine("1.Add a menu item");
            Console.WriteLine("2.View the cheepest item in the menu");
            Console.WriteLine("3.View the drink's menu");
            Console.WriteLine("4.View the food's menu");
            Console.WriteLine("5.Add order");
            Console.WriteLine("6.FullFill the order");
            Console.WriteLine("7.View the order's list");
            Console.WriteLine("8.Total payable amount");
            Console.WriteLine("9.Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}

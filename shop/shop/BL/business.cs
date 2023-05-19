using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.UI;

namespace shop.BL
{
   
        public class MenuItem
        {
            public string Item_Name;
            public string Item_Type;
            public int Item_Price;
            public MenuItem(string Item_Name, string Item_Type, int Item_Price)
            {
                this.Item_Name = Item_Name;
                this.Item_Type = Item_Type;
                this.Item_Price = Item_Price;
            }

            public MenuItem()
            {
                
            }
        }

        public class CoffeeShop
        {
            public string Shop_Name = "twinkle twinkle little starts";
            public static List<MenuItem> menu = new List<MenuItem>();
            public static List<string> Orders =new List<string>();

            public CoffeeShop(string Shop_Name)
            {
                this.Shop_Name = Shop_Name;
            }

            public CoffeeShop()
            {

            }

        }
}

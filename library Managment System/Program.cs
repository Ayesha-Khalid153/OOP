using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_Managment_System
{
    class Program
    {
        public class books
        {
            public string author;
            public int pages;
            List<string> Chapters;
            public int bookMarks;
            public int price;
            public int chapterNumber;
            public int setChapter(int chapterNumber)
            {

                return chapterNumber;
            }

            public int getChapter(int chapterNumber)
            {
                setChapter(chapterNumber);
                return chapterNumber;
            }

            public books()
            {

            }

            public books(string author, int pages, int bookMarks, int price, List<string> Chapters)
            {
                this.author = author;
                this.pages = pages;
                this.bookMarks = bookMarks;
                this.price = price;
                this.Chapters = Chapters;
            }

            public books take_Input()
            {
                List<string> Chapters = new List<string>();
                //Console.WriteLine("Enter the Number Of the Chapters you wanna add : ");
                //int chapterNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Name of the Author..");
                string author = Console.ReadLine();
                Console.WriteLine("Enter the page no of the Book..");
                int pages = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Bookmark of the Book..");
                int bookMarks = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Price of the Book..");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter how many chapters you want to add in this book");
                int count = int.Parse(Console.ReadLine());

               
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter the name of the chapter ..");
                    string sa = Console.ReadLine();
                    Chapters.Add(sa);
                }
                books l = new books(author, pages, bookMarks, price, Chapters);
                return l;
            }

            public string NameOFChapter(int chapterNumber)
            {
                for (int idx = 0; idx < Chapters.Count; idx++)
                {
                    if (chapterNumber == idx)
                    {
                        return Chapters[idx];
                    }
                }
                return null;
            }
            public int getBookMark()
            {
                return bookMarks;
            }

            public void setBookMark(int pageNumber)
            {

                bookMarks = pageNumber;
            }

            public int getBookPrice()
            {
                return price;
            }

            public void setBookPrice(int book_Price)
            {
                price = book_Price;
            }
        }
        static void Main(string[] args)
        {
            List<books> book = new List<books>();
            books b = new books();
            int optionMenu = 0;

            do
            {
                Console.Clear();
                optionMenu = menu();
                if (optionMenu == 1)
                {
                    b = b.take_Input();
                    book.Add(b);
                }

                

                else if (optionMenu == 2)
                {
                    Console.WriteLine("Enter the chapter number whose name you want : ");
                    int chapternumber = int.Parse(Console.ReadLine());
                    chapternumber = chapternumber - 1;
                    string cn = b.NameOFChapter(chapternumber);
                    chapternumber++;
                    Console.WriteLine("The name of the chapter at the index " + chapternumber + " is " + cn);
                    Console.ReadKey();
                }

                else if (optionMenu == 3)
                {
                    int bookMark = b.getBookMark();
                    Console.WriteLine("BookMark is on page number : " + bookMark);
                    Console.ReadKey();
                }

                else if (optionMenu == 4)
                {
                    Console.WriteLine("Enter the page number on which you want to set the mark?");
                    int bookMarks = int.Parse(Console.ReadLine());
                    b.setBookMark(bookMarks);
                    Console.WriteLine("Your update bookmark is now on page number " + b.bookMarks);
                    Console.ReadKey();
                }
                else if (optionMenu == 5)
                {

                    int book_Price = b.getBookPrice();
                    Console.WriteLine("Book Price is : " + book_Price);
                    Console.ReadKey();
                }
                else if (optionMenu == 6)
                {
                    Console.WriteLine("Enter the new book price of the book");
                    int bookprice = int.Parse(Console.ReadLine());
                    b.setBookPrice(bookprice);
                    Console.WriteLine("Your update bookprice is now " + b.price);
                    Console.ReadKey();
                }

                else if (optionMenu == 7)
                {
                    break;
                }
            }
            while (optionMenu < 8);
            Console.ReadKey();
        }

        static int menu()
        {
            int option;
            Console.WriteLine("1.Add the info of the book");
            Console.WriteLine("2.Get the name of chapter");
            Console.WriteLine("3.Get on which page is the bookmark");
            Console.WriteLine("4.Set the new bookmark");
            Console.WriteLine("5.Get the price of the book");
            Console.WriteLine("6.Set the new price of book");
            Console.WriteLine("7.Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }



    }
}

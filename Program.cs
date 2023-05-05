using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_class
{


    class Program
    {
        public class credentials
        {
            public string names;
            public string password;
            List<credentials> user = new List<credentials>();
        }
        public class noodlesData
        {
            public string nod_Names;
            public int nod_Price;
            public int nod_Stock;
        }

        static void Main(string[] args)
        {
            List<credentials> s2 = new List<credentials>();
            List<noodlesData> noodle = new List<noodlesData>();
            List<credentials> user = new List<credentials>();
            int nod_Counter = 0;
            string path = "C:\\Users\\Feb12\\Desktop\\data.txt";
            int usersCount = 0;
            int userArrSize = 100;
            //List<credentials> s2 = new List<credentials>();
            List<noodlesData> a1 = new List<noodlesData>();

            readNoodlesData(a1);
            int option;
            readData(path, s2);  


            do
            {
                option = Menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name : ");
                    string n = Console.ReadLine();
                    bool flag = true;
                    while (flag)
                    {
                        for (int i = 0; i < n.Count(); i++)
                        {
                            if (!((n[i] >= 97 && n[i] <= 122) || (n[i] >= 65 && n[i] <= 90)))
                            {
                                Console.WriteLine("Invalid!! Enter Again : ");
                                n = Console.ReadLine();
                                break;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                    }
                    Console.WriteLine("Enter Password : ");
                    string p = Console.ReadLine();
                    signUp(path, n, p, s2, ref usersCount, ref userArrSize);

                }
                else if (option == 2)
                {
                    credentials s = new credentials();
                    Console.WriteLine("Enter Name : ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    string p = Console.ReadLine();
                    signIn(n, p, s2);
                    adminInterface(a1, ref nod_Counter);
                    Console.ReadKey();
                }
                
            }
            while (option < 3);
            Console.ReadKey();
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.SignUp with you Credential");
            Console.WriteLine("2.SignIn with you Credential");
            Console.WriteLine("3.Exit the Application");
            Console.WriteLine("Enter Your Option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void readData(string path, List<credentials> s2)
        {
            List<string> c = new List<string>();
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    credentials info = new credentials();
                    info.names = parseData(record, 1);
                    info.password = parseData(record, 2);
                    s2.Add(info);
                }
                fileVariable.Close();
            }
            else
            {
                Console.Write("Doesnot Exists");
            }
        }
        static void writeItemDataInFile( List<noodlesData> a1)
        {
            StreamWriter myfile = new StreamWriter("C:\\Users\\Feb12\\Desktop\\nooData.txt");
            for (int i = 0; i < a1.Count; i++)
            {
                myfile.WriteLine(a1[i].nod_Names + "," + a1[i].nod_Price + "," + a1[i].nod_Stock);
            }
            myfile.Flush();
            myfile.Close();

        }

        static void readNoodlesData(List<noodlesData> a1)
        {
            if (File.Exists("‪‪C:\\Users\\Feb12\\Desktop\\nooData.txt"))
            {
                StreamReader fileVariable = new StreamReader("C:\\Users\\Feb12\\Desktop\\nooData.txt");
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    noodlesData info = new noodlesData();
                    info.nod_Names = parseData(record, 1);
                    info.nod_Price = int.Parse(parseData(record, 2));
                    info.nod_Stock = int.Parse(parseData(record, 3));
                    
                    a1.Add(info);
                    Console.WriteLine("ayesha kajkj");
                    Console.ReadKey();
                }
                fileVariable.Close();
            }
            else
            {
                Console.Write("Doesnot Exists hhjh");
            }
        }
        static void signIn(string n, string p, List<credentials> users)
        {
            bool flag = false;
            for (int x = 0; x < users.Count; x++)
            {
                if (n == users[x].names && p == users[x].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("You have entererd wrong I'd!");
            }
            Console.ReadKey();
        }
        static void signUp(string path, string n, string p, List<credentials> s2, ref int usersCount, ref int userArrSize)
        {
            StreamWriter myfile = new StreamWriter(path, true);
            myfile.WriteLine(n + "," + p);
            myfile.Flush();
            myfile.Close();
            if (usersCount < userArrSize)
            {
                s2[usersCount] = addUserData(n, p, ref s2, ref usersCount);
                usersCount++;
            }
        }
        static credentials addUserData(string n, string p, ref List<credentials> s2, ref int usersCount)
        {
            credentials s1 = new credentials();
            s1.names = n;
            s1.password = p;
            return s1;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];

                }
            }
            return item;
        }
        static void adminInterface(List<noodlesData> a1, ref int nod_Counter)
        {

            List<noodlesData> noodle = new List<noodlesData>();
            while (true)
            {
                int choose = 0;
                choose = adminMainMenu();
                if (choose == 1)
                {
                    Console.Clear();
                    //nodles.ADD();
                    adminOption1(a1, ref  nod_Counter);
                }
                if (choose == 2)
                {
                    Console.Clear();
                    adminOption2(a1, ref nod_Counter); ;
                }
                if (choose == 3)
                {
                    Console.Clear();
                    adminOption3( a1, ref nod_Counter);
                }
                else if (choose == 4)
                {
                    adminOption4(a1);
                    Console.ReadKey();
                }
                    Console.Clear();
            }

        }

        static int adminMainMenu()
        {
            int option;
            Console.WriteLine("1. Add noodles in stock");
            Console.WriteLine("2. Remove noodles from the stock");
            Console.WriteLine("3. Update price");
            Console.WriteLine("4. View noodles details");
            Console.WriteLine("Enter option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void adminOption1( List<noodlesData> a1, ref int nod_Counter)
        {

            noodlesData o = new noodlesData();
            int numbers;
            Console.Clear();

            Console.WriteLine("how  many products you wanna add?");
            numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of the noodle: ");
            o.nod_Names = Console.ReadLine();
            Console.WriteLine("Enter the price of noodle: ");
            o.nod_Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the stock of this noodle: ");
            o.nod_Stock = int.Parse(Console.ReadLine());
            writeItemDataInFile( a1);
            a1.Add(o);
            Console.Clear();

        }
        static void adminOption2( List<noodlesData> a1, ref int nod_Counter)
        {
            Console.Clear();
            Console.Write("Enter Position of item you want to delete: ");
            int itemPos = int.Parse(Console.ReadLine());
            for (int i = itemPos - 1; i < a1.Count; i++)
            {
                a1.RemoveAt(i);
            }
            Console.WriteLine("Item has deleted!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            writeItemDataInFile( a1);  
        }
        static void adminOption3(List<noodlesData> a1, ref int nod_Counter)
        {
            Console.Clear();
            bool flag = false;

            Console.Write("Enter Position of item you want to update: ");
            int pos = int.Parse(Console.ReadLine());
            for (int i = pos - 1; i < a1.Count; i++)
            {
                if (pos <= a1.Count)
                {
                    flag = true;

                }
                if (flag == true)
                {
                    Console.WriteLine("Enter new price of item: ");
                    int Price = int.Parse(Console.ReadLine());
                    a1[i].nod_Price = Price;
                    Console.WriteLine("Enter new stock of item: ");
                    int stock = int.Parse(Console.ReadLine());
                    a1[i].nod_Stock = stock;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Item don't exist");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            writeItemDataInFile( a1);

        }
        static void adminOption4(List<noodlesData> a1)
        {
            Console.Clear();
            Console.WriteLine("Noodle type name " + " : "+ "Noodle price "  + " : "+ "Stock of noodles" );
            for (int idx = 0; idx < a1.Count; idx++)
            {
                Console.WriteLine(a1[idx].nod_Names + "             :     " + a1[idx].nod_Price + "         :  " + a1[idx].nod_Stock );
            }
        }
        
    }
}
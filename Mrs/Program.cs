using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collegeManagmentSystem
{
    class Program
    {
        class students
        {
            public string Name;
            public int rollNumber;
            public float cGPA;
            public int matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public string homeTown;
            public string Check_Hostelite;
            //public bool isHostelite;
            public bool isTakingScholarship;
            public students()
            {
            }

            public students(string Name, int rollNumber, float cGPA, int matricMarks, float fscMarks, float ecatMarks, string homeTown, string Check_Hostelite, bool isTakingScholarship)
            {
                this.Name = Name;
                this.rollNumber = rollNumber;
                this.cGPA = cGPA;
                this.matricMarks = matricMarks;
                this.fscMarks = fscMarks;
                this.ecatMarks = ecatMarks;
                this.homeTown = homeTown;
                this.Check_Hostelite = Check_Hostelite;
                this.isTakingScholarship = isTakingScholarship;
            }
            public students ak()
            {
                Console.WriteLine("What is the name of the student?");
                Name = Console.ReadLine();
                Console.WriteLine("What is the rollNumber of the student?");
                rollNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the cGPA of the student?");
                cGPA = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the matricMarks of the student?");
                matricMarks = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the fscMarks; of the student?");
                fscMarks = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the ecatMarks of the student?");
                ecatMarks = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the homeTown of the student?");
                homeTown = Console.ReadLine();
                Console.WriteLine("Is the student isHostelite?");
                Check_Hostelite = Console.ReadLine();

                students o = new students(Name, rollNumber, cGPA, matricMarks, fscMarks, ecatMarks, homeTown, Check_Hostelite, isTakingScholarship);
                return o;
            }
            public float claculateMerit()
            {
                float meritPercentage;
                ecatMarks = (ecatMarks * 40.0F) / 100;
                fscMarks = (fscMarks * 60.0F) / 100;
                meritPercentage = ecatMarks + fscMarks;
                return meritPercentage;
            }
            public bool isEligibleforScholarship(double meritPercentage)
            {
                bool flag = false;
                //claculateMerit();
                if (meritPercentage > 80)
                {
                    Console.WriteLine("Eligible");
                    return true;
                }
                else
                {
                    Console.WriteLine("not Eligible");
                    return flag;
                }

            }
        }

        static void Main(string[] args)
        {
            students obj = new students();
            List<students> a = new List<students>();
            int option = 0;
            float meritPercentage = 0;

            do
            {
                Console.Clear();
                option = menu(option);
                Console.Clear();
                if (option == 1)
                {
                    students o = obj.ak();
                    a.Add(o);

                }
                else if (option == 2)
                {
                    meritPercentage = obj.claculateMerit();
                    Console.WriteLine(meritPercentage);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    bool flag = obj.isEligibleforScholarship(meritPercentage);
                    Console.WriteLine(meritPercentage);
                    Console.ReadKey();
                }
            } while (option < 4);
            Console.ReadLine();
            Console.ReadKey();

        }

        static int menu(int option)
        {
            Console.WriteLine("1.Check the student details..");
            Console.WriteLine("2.Check the merit details of student details..");
            Console.WriteLine("3.Check whether the studednt is eligible for scholarship or not and will have the hostal or not..");
            Console.WriteLine("Choose anay option..");
            option = int.Parse(Console.ReadLine());

            return option;
        }
    }
}

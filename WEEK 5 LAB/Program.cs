using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_LAB
{

    class Students
    {
        public string names;
        public int rollNo;
        public float Ecat_Marks;

        public Students (string names, int rollNo, float Ecat_Marks)
        {
            this.names = names;
            this.rollNo = rollNo;
            this.Ecat_Marks = Ecat_Marks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students("Ahmed" , 1 , 123.5F) ;
            Students s2 = new Students("Ahmed" , 3 , 234.5F) ;
            Students s3 = new Students("Ahmed" , 2 , 111.5F) ;

            List<Students> student_List = new List<Students>() { s1, s2, s3 };
            List<Students> sortedList = student_List.OrderBy(o => o.Ecat_Marks ).ToList();
            //List<Students> sorted_List = student_List.OrderBy(o => o.rollNo).ToList();
            foreach(Students s in sortedList)
            {
                Console.WriteLine("{0} \t {1} \t {2}", s.names, s.rollNo, s.Ecat_Marks);
            }
            //foreach (Students s in sorted_List)
            //{
            //    Console.WriteLine("{0} \t {1} \t {2}", s.names, s.rollNo, s.Ecat_Marks);
            //}
            Console.ReadKey();
        }
    }
}

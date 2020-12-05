using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Declare a dictionary based collection of Employee class objects 
namespace Day6
{
    class Day6Assi1
    {
        public static int count = 0;
        static void Maine()
        {
            SortedList<int, Employee> ss = new SortedList<int, Employee>();
            bool fg = true;
            
            for(int i=0;true;i++)
            {
                count++;
                Console.WriteLine("Enter false to stop and true to continue");
               
                fg = Convert.ToBoolean(Console.ReadLine());
               // Console.WriteLine(fg);
                if (fg == false)
                    break;
                Console.WriteLine("Enter empNo and Name and salary");
                int no = Convert.ToInt32(Console.ReadLine());
                string nm= Console.ReadLine();
                double sal = Convert.ToInt64(Console.ReadLine());

                ss.Add(count, new Employee { EMPNO = no, NAME = nm ,SALARY=sal});
            }
            //ss.Add(1,new Employee { EMPNO = 1, NAME = "Anjali" });
            //ss.Add(2, new Employee { EMPNO = 2, NAME = "puja" });
            
            foreach (KeyValuePair<int,Employee> kvp in ss)
            {
                
                Console.Write("Key is =  " + kvp.Key + " ");

                Console.Write("Emplyee Info is:");
                Console.WriteLine( " " + kvp.Value.EMPNO + "   " +  kvp.Value.NAME +  " " +kvp.Value.SALARY);
            }

            //Emp with highest Salary
            double max=0;
            for (int i = 0; i < ss.Count; i++)
            {
                 max = ss.Values[0].SALARY;
                if(ss.Values[i].SALARY > max)
                {
                    max = ss.Values[i].SALARY;
                }
            }
            for(int i=0;i<ss.Count;i++)
            {
                if(ss.Values[i].SALARY == max)
                {
                    Console.WriteLine("Employee with max slary is {0} having salary {1} ",ss.Values[i].NAME,
                         ss.Values[i].SALARY);
                }
            }
            // Emp to be search
            Console.WriteLine(  "Enter emp to be searched");
            int empno = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ss.Count; i++)
            {
                if(empno== ss.Values[i].EMPNO)
                {
                    Console.WriteLine("Emp deatals are =" +ss.Values[i].EMPNO + " " + ss.Values[i].NAME + " " +
                        ss.Values[i].SALARY);
                }
            }
            Console.WriteLine("Enter count that how many employee info yu want");
            int ct = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ct; i++)
            {
                
              Console.WriteLine("Emp deatals are =" + ss.Values[i].EMPNO + " " + ss.Values[i].NAME + " " +
                        ss.Values[i].SALARY);
                
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int EMPNO
        {
            set;get;
        }
        public string NAME
        {
            set;get;
        }
        public double SALARY
        {
            set;get;
        }
    }
}

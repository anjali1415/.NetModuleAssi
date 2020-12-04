using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Day5Assi1
    {
        static void Main(string[] args)

        {
            Employee[] arr = new Employee[3];
             for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter the empNo, name,salary:");
                int eNo = Convert.ToInt32(Console.ReadLine());
                
                string nm = Console.ReadLine();
                double sal = Convert.ToInt64(Console.ReadLine());
                Employee e = new Employee(eNo,sal,nm);
                arr[i] = e;
                    
               
            }
              foreach(Employee item in arr )
            {
                item.show();
            }
            double max = arr[0].SALARY;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i].SALARY > max)
                {
                    max = arr[i].SALARY;
                }
            }
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i].SALARY == max)
                {

                    Console.WriteLine("The employee with max salary is {0} having salary is {1}",arr[i].NAME,max);
                    
                }
            }
            Console.WriteLine("Enter emp no to be saerched");
            int empSerch = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EMPNO == empSerch)
                {
                    Console.WriteLine(arr[i].EMPNO+ " "  + arr[i].NAME+ " "  + arr[i].SALARY);
                }
            }
            Console.ReadLine();
        }
         
    }
    public class Employee
    {
        private string name;
        private  int empNo;
        private double salary;

        // name
        public string NAME
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        // salary
        public double SALARY
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
        //empno
        public int EMPNO
        {
            set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        public Employee()
        {
                
        }
        public Employee(int empNo,double salary,string name)
        {
            this.EMPNO = empNo;
            this.NAME = name;
            this.SALARY = salary;
        }
        public void show()
        {
            Console.WriteLine(EMPNO + " " + NAME + " " + SALARY);
        }
    }
}

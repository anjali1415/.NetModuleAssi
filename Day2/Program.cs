using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssi
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);




            Employee e1 = new Employee("Anjali", 700, 10);
            Console.WriteLine("Gross salary for for {0} is {1} " ,e1.Name,e1.GetNetSalary());
            Console.WriteLine(e1.EmpNo);
            Employee e2 = new Employee("tushar", 800);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine("Gross salary for {0} is {1}", e2.Name,e2.GetNetSalary());
            Employee e3 = new Employee("");
            Console.WriteLine(e3.Name);


            Console.ReadLine();


        }
    }
    class Employee
    {
        private string name;
       // private int empNo;
        private decimal basic;
        private short deptNo;
        public static int tempno;


         // for empno
         public int EmpNo
        {
            get;
        }
        //basic
        public decimal Basic
        {
            set
            {
                if (value <= 2000 && value >= 500)
                    basic = value;
                else
                {
                    Console.WriteLine("Not valid num:");
                }
            }
            get
            {
                return basic;
            }
        }
        //deptNo
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Not valid dept No.");
            }
            get
            {
                return deptNo;
            }
        }
        //name
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value) == false)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine( "Give proper Name:");
                }
            }
            get
            {
                return name;
            }
        }
        public Employee()
        {

            tempno++;
            this.EmpNo = tempno;
        }
        public Employee(string nm,decimal bc,short dptno)
        {
            tempno++;
            this.EmpNo = tempno;
           
            this.Basic = bc;
            this.Name = nm;
            this.DeptNo = dptno;
        }
        public Employee(string nm, decimal bc)
        {
            tempno++;
            this.EmpNo = tempno;
            this.Basic = bc;
            this.Name = nm;
        }
        public Employee(string nm)
        {
            tempno++;
            this.EmpNo = tempno;
            this.Name = nm;
            this.EmpNo = tempno;
        }
        //methods
        public decimal GetNetSalary()
        {
            decimal grsSal = Basic + 1000;
            return grsSal;
        }
    }
}

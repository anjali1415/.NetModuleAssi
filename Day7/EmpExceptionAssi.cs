
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class EmpExceptionAssi
    {
        static void Main2(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);




            try
            {
                Employee e1 = new Employee("", 200, 0);
                Console.WriteLine("Gross salary for for {0} is {1} ", e1.Name, e1.GetNetSalary());
                Console.WriteLine(e1.EmpNo);
               // Employee e2 = new Employee("tushar", 800);
                //Console.WriteLine(e2.EmpNo);
                //Console.WriteLine("Gross salary for {0} is {1} {2}", e2.Name, e2.GetNetSalary(), e2.DeptNo);
                Employee e3 = new Employee("leena", 900);
                Console.WriteLine(e3.EmpNo);
                Console.WriteLine("Gross salary for {0} is {1} {2}", e3.Name, e3.GetNetSalary(), e3.DeptNo);
                //Employee e3 = new Employee("");
                //Console.WriteLine(e3.Name);
            }catch(InvalidDeptNumber edpt)
            {
                Console.WriteLine(edpt);
            }catch(InvalidBasicException1 eb)
            {
                Console.WriteLine(eb);
            }catch(InvalidNameExcpetion nm)
            {
                Console.WriteLine(nm);
            }

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
                    ApplicationException ebc;
                    ebc = new InvalidBasicException1("Invalid basic it should be between 5000 to 2000 ");
                    throw ebc;
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
                if (value >= 1)
                    deptNo = value;
                else
                {
                    ApplicationException axp;
                    axp = new InvalidDeptNumber("Invalid dept No");
                    throw axp;
                }
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
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    ApplicationException expp = new InvalidNameExcpetion("Enter valid name");
                    throw expp;
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
        public Employee(string nm = "abc", decimal bc = 789, short dptno = 10)
        {
            tempno++;
            this.EmpNo = tempno;

            this.Basic = bc;
            this.Name = nm;
            this.DeptNo = dptno;
        }
        
        //methods
        public decimal GetNetSalary()
        {
            decimal grsSal = Basic + 1000;
            return grsSal;
        }
    }
    public class  InvalidDeptNumber: ApplicationException
    {
        public InvalidDeptNumber(string msg) : base(msg)
        {

        }
    }
    public class InvalidBasicException1 : ApplicationException
    {
        public InvalidBasicException1(string ms1):base(ms1)
        {

        }
    }
    public class InvalidNameExcpetion : ApplicationException
    {
        public InvalidNameExcpetion(string msg2):base(msg2)
        {
                
        }
    }
}

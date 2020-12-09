using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public delegate void NameInvlidDeligate(string name);
    public delegate void BasicInvalidDeligate(decimal basic);
    public delegate void DeptNoInvaliDelegate(int deptNo);
    class EmpHandlerAssi
    {
        static void Main(string[] args)
        {

            Employee11 empobj = new Employee11(Empobj_InvalidName,Empobj_InvalideptNo,Empobj_InvalidBasic,"Anjali" ,1200,10);
           // empobj.InvalidBasic += Empobj_InvalidBasic;
           // empobj = new Employee11 { Basic = 9000, Name = "Anjali", DeptNo = 1 };
           
            Console.WriteLine(empobj.EmpNo + " " + empobj.Name + " " + empobj.Basic + " " + empobj.DeptNo);

           // empobj = new Employee11(Empobj_InvalidName, Empobj_InvalideptNo, Empobj_InvalidBasic, "", 1200, 10);
           // Console.WriteLine(empobj.EmpNo + " " + empobj.Name + " " + empobj.Basic + " " + empobj.DeptNo);
            
            //empobj = new Employee11(Empobj_InvalidName, Empobj_InvalideptNo, Empobj_InvalidBasic, "Anjali", 100, 10);
           // Console.WriteLine(empobj.EmpNo + " " + empobj.Name + " " + empobj.Basic + " " + empobj.DeptNo);
            
            empobj = new Employee11(Empobj_InvalidName, Empobj_InvalideptNo, Empobj_InvalidBasic, "Anjali", 1200, 0);
            Console.WriteLine(empobj.EmpNo + " " + empobj.Name + " " + empobj.Basic + " " + empobj.DeptNo);
            
            Console.ReadLine();


        }

        private static void Empobj_InvalideptNo(int deptNo)
        {
            Console.WriteLine("Your eneterd dept No is not valid :" + deptNo);
        }

        private static void Empobj_InvalidBasic(decimal Value)
        {
            Console.WriteLine("Your entered basic is" + Value);
        }

        private static void Empobj_InvalidName(string Value)
        {
            Console.WriteLine("Enter valid name " + Value); 
        }
    }
    class Employee11
    {
        public event NameInvlidDeligate InvalidName;
        public event BasicInvalidDeligate InvalidBasic;
        public event DeptNoInvaliDelegate InvalideptNo;
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
                    InvalidBasic(value);
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
                {
                    InvalideptNo(value);
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
                if (value !=null)
                {
                    name = value;
                }
                else
                {
                   //if(InvalidName != null) 
                    InvalidName(value); 
                }
            }
            get
            {
                return name;
            }
        }
        public Employee11()
        {

        }
        public Employee11(NameInvlidDeligate InvalidName ,DeptNoInvaliDelegate InvalideptNo, BasicInvalidDeligate InvalidBasic,
            string nm ="", decimal bc = 789, short dptno = 10)
        {
            tempno++;
            this.EmpNo = tempno;
            this.InvalidBasic = InvalidBasic;
            this.InvalideptNo = InvalideptNo;
            this.InvalidName = InvalidName;
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
    
    
}


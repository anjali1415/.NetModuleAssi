using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class EmpAssi3
    {
        static void Main()
        {
            Manager e1 = new Manager("HR", "Tush", 80000, 11);

            Console.WriteLine(e1.EmpNo + " " + e1.Name + e1.CalcNetSalary() + " " + e1.Designation);
            GeneralManager e2 = new GeneralManager("kitkat", "clerk", "Leena", 82000, 12);
            Console.WriteLine(e2.perks + " " + e2.EmpNo + " " + e2.Name + " " + e2.CalcNetSalary() + e2.Designation);
            Employee e3 = new CEO("Tush", 83000, 11);
            Console.WriteLine(e3.EmpNo + " " + e3.Name + " " + e3.CalcNetSalary());
            // Interface
            Manager m = new Manager();
            InsertMethod(m);
            GeneralManager m1 = new GeneralManager();
            InsertMethod(m1);
            CEO c = new CEO();
            InsertMethod(c);
            ///Employee e = new Manager();
            //InsertMethod(e);
            Console.ReadLine();
        }

        static void InsertMethod(IdbFunctions oIDb)
        {
            oIDb.Insert();
            oIDb.Delete();
            oIDb.update();
        }
    }
    public interface IdbFunctions
    {
        void Insert();
        void Delete();
        void update();
    }
    public abstract class Employee:IdbFunctions
    {
        private string name;
        public static int tempEmpNo;
        private short deptNo;
        public abstract decimal CalcNetSalary();

        public void Insert()
        {
            Console.WriteLine("In Emp insert");
        }

        public void Delete()
        {
            Console.WriteLine("In Emp delete");
        }

        public void update()
        {
            Console.WriteLine("In Emp update");
        }

        public Employee()
        {
           // Console.WriteLine("non param ctr emp");
        }
        public Employee(string name = "Anjali", decimal basic = 1000, short deptNo = 10)
        {
            this.EmpNo = ++tempEmpNo;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }
        //To set abstract 
        protected decimal basic;
        public abstract decimal Basic
        {
            set; get;
        }

        public int EmpNo
        {
            get;
        }

        public string Name
        {
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Enter valid name");
            }
            get
            {
                return name;
            }
        }
        public int DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = (short)value;
                else
                {
                    Console.WriteLine("Enter correct deptNo:");
                }
            }
            get
            {
                return deptNo;
            }

        }
    }
    public class Manager : Employee, IdbFunctions
    {
        private string designation;
        public Manager()
        {

        }
        public Manager(string desi, string nm, decimal basic, short dpt) : base(nm, basic, dpt)
        {
            this.Designation = desi;
        }
        public string Designation
        {
            set
            {
                if (value != "")
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Enter proper designation");
                }
            }
            get
            {
                return designation;
            }
        }

        public override decimal Basic
        {


            set
            {
                if (value >= 50000 && value <= 150000)
                    basic = value;
                else
                    Console.WriteLine("Enter valid basic");
            }
            get
            {
                return basic;
            }
        }



        public override decimal CalcNetSalary()
        {
            return Basic + 1000;
        }

        public void Delete()
        {
            Console.WriteLine("In manager delete");
        }

        public void Insert()
        {
            Console.WriteLine("In manager insert");
        }

        public void update()
        {
            Console.WriteLine("In manager update");
        }
    }
    public class GeneralManager : Manager,IdbFunctions
    {
        public string perks;
        public GeneralManager()
        {
                
        }
        public GeneralManager(string prk, string desi, string nm, decimal basic, short dpt) : base(desi, nm, basic, dpt)
        {
            perks = prk;

        }
        public override decimal Basic
        {


            set
            {
                if (value >= 50000 && value <= 150000)
                    basic = value;
                else
                    Console.WriteLine("Enter valid basic");
            }
            get
            {
                return basic;
            }
        }
        public override decimal CalcNetSalary()
        {
            return Basic + 1000;
        }
        public void Delete()
        {
            Console.WriteLine("In Generalmanager delete");
        }

        public void Insert()
        {
            Console.WriteLine("In Generalmanager insert");
        }

        public void update()
        {
            Console.WriteLine("In Generalmanager update");
        }
    }
    public class CEO : Employee,IdbFunctions
    {
        public CEO()
        {
                
        }

        public CEO(string nm, decimal bc, short dept) : base(nm, bc, dept)
        {

        }
        public override decimal Basic
        {


            set
            {
                if (value >= 50000 && value <= 150000)
                    basic = value;
                else
                    Console.WriteLine("Enter valid basic");
            }
            get
            {
                return basic;
            }
        }

        public sealed override decimal CalcNetSalary()
        {
            return Basic + 1000;
        }

        public void Delete()
        {
            Console.WriteLine("In Ceo delete");
        }

        public void Insert()
        {
            Console.WriteLine("In CEO insert");
        }

        public void update()
        {
            Console.WriteLine("In CEO update");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class LambdaAssi1
    {
        static void Main8()
        {
            decimal ans = 0;

            Func<decimal, decimal, decimal,decimal> lamobj = (P,T,R) =>
              {
                  ans =( P * T * R) / 100;
                  return ans;
              };
            Console.WriteLine("Simple Intrest:" + lamobj(1000,2,2));
            Console.Read();
        }
    }
}
namespace Day8
{
    class LambdaAssi2
    {
        static void Main9()
        {
          Func<int,int,bool> op=(a,b) =>
             {
                 if (a > b)
                     return true;
                 else
                     return false;
             };

            Console.WriteLine( op(10,7));
            Console.ReadLine();
        }
    }
}

//decimal GetBasic(Employee e) -> returns the Basic salary of the employee
namespace Day8
{
    class LambdaAssi3
    {
        static void Main11()
        {
            Func<Employee,decimal> as3 = (e) =>
              {
                  return e.BASICSAL + 1000;
              };
            Employee e1 = new Employee(450);
            Console.WriteLine("The Employee basic Salary is:"+as3(e1)) ;
            Console.Read();
        }
        class Employee
        {
            private decimal basicsal;
            public decimal BASICSAL
            {
                set
                {
                    basicsal = value;

                }
                get
                {
                    return basicsal;
                }
            }
            public Employee(decimal basic)
            {
                this.BASICSAL = basic;  
            }
        }
    }
}
//4. bool IsEven(int num) -> returns true if the number is an even number
namespace Day8
{
    class LambdaAssi4
    {
        static void Main12()
        {
            Predicate<int> pr = (a) =>
              {
                  return a % 2 == 0;
              };
            Console.WriteLine(pr(4));
            Console.Read();

        }

    }
}
//5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000
namespace Day8
{
    class LambdaAssi5
    {
        static void Main()
        {

            Predicate<Employee> as5 = (emp) =>
              {
                  return emp.BASICSALARY > 10000;
              };
            Console.WriteLine("Enter basic salary");
            int sal=Convert.ToInt32( Console.ReadLine());
            Employee e2 = new Employee(sal);
            Console.WriteLine(as5(e2));

            Console.Read();

        }

    }
    public class Employee
    {
        private int basicSalary;
        public int BASICSALARY
        {
            set
            {
                this.basicSalary = value;
            }
            get
            {
                return basicSalary;
            }
        }
        public Employee(int basicsal)
        {
            this.BASICSALARY = basicsal;  
        }
    }
}
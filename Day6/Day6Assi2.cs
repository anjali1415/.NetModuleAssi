using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Day6Assi2
    {
        static void Main()
        {
            EmpDemo[] arr = new EmpDemo[2];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter empno ");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter age ");
                int age = Convert.ToInt32(Console.ReadLine());
                arr[i] = new EmpDemo();
                arr[i].EMPNO = no;
                arr[i].AGE = age;
            }
            Console.WriteLine("With array");
            foreach(EmpDemo o in arr)
            {
                Console.WriteLine(" age = " + o.AGE + " EmpNo is =  "  + o.EMPNO);
            }
            List<EmpDemo> l1 = arr.ToList<EmpDemo>();
            Console.WriteLine("With List ");
            foreach (EmpDemo l in l1)
            {
                Console.WriteLine(" age = " + l.AGE + " EmpNo is =  " + l.EMPNO);
            }
            Console.ReadLine();
        }
    }
    public class EmpDemo
    {
        public int EMPNO
        {
            set;get;
        }
        public int AGE
        {
            set;get;
        }
    }
    
}

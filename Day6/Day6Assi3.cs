using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Day6Assi3
    {
        static void Mainee()
        {

            List<Emp11> li = new List<Emp11>();
            li.Add(new Emp11 { DeptNo = 1, Name = "xyz" });
            li.Add(new Emp11 { DeptNo = 2, Name = "pqr" });

            /* foreach (Emp11 e in li)
             {
                 Console.WriteLine(e.Name + " " + e.DeptNo);
             }*/
            object[] arr = li.ToArray();

            foreach (Emp11 e in arr)
            {
                Console.WriteLine(e.Name + " " + e.DeptNo);
            }
            Console.ReadLine();
        }
    }

    public class Emp11
    {
        public int DeptNo
        {
            set; get;
        }
        public string Name
        {
            set; get;
        }
    }
}
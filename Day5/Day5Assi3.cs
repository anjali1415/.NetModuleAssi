using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Day5Assi3
    {
        static void Main()
        {
            Student s3 = new Student();
            s3.MARKS = 0;
            s3.NAME = "xyz";
            s3.ROLLNO = 0;
            Student[] arr = new Student[5];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter name,roll no ,marks");
                string nm = Console.ReadLine();
                int roll = Convert.ToInt32(Console.ReadLine());
                //decimal marks = Convert.ToInt128(Console.ReadLine());
                decimal mk = Decimal.Parse(Console.ReadLine());
                Student s1 = new Student();
                Student s=new Student(mk,nm,roll);
                arr[i] = s;
            }
        }
    }
    public struct Student
    {
        string Name;
        int RollNo;
        decimal Marks;
        public string NAME
        {
            set
            {
                if(value != null)
                Name = value;
                else
                    Console.WriteLine("Enter valid name");
            }
            get
            {
                return Name;
            }
        }
        public int ROLLNO
        {
            set
            {
                if (value != 0)
                    RollNo = value;
                else
                    Console.WriteLine("Enter valid roll no");
            }
            get
            {
                return RollNo;
            }
        }
        public decimal MARKS
        {
            set
            {
                if (value > 40)
                    Marks = value;
                else
                {
                    Console.WriteLine(" Not eligible for passing");
                }
            }
            get
            {
                return Marks;
            }
        }

        public Student(decimal Marks,string Name,int RollNo)
        {
            
            NAME = Name;
            ROLLNO = RollNo;
            MARKS = Marks;
        }

    }
}

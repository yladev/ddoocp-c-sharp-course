using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class clsStudentMarks
    {
        static void Main(string[] args)
        {
            int mark;
            Console.WriteLine("Please Enter Your Mark: ");
            mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 40 && mark <= 100)
            {
                Console.WriteLine("Your mark is: " + mark);
                Console.WriteLine("Pass");
            }
            else if(mark>=0 && mark<=39)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid Number");            
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class clsInputData
    {
        static void Main(string[] args)
        {
            // int i = 10, j;
            //  j = i++;
            // Console.WriteLine("i = " + i + "\t j = " + "\t" + j);
            
            const double pi = 3.14;
            Console.Write("Please Enter Radis : ");
            int r = Convert.ToInt32(Console.ReadLine());
            double result;
            result = pi * r * r;
            Console.WriteLine("Const Result = " + result);
            Console.Read();
        }
    }
}

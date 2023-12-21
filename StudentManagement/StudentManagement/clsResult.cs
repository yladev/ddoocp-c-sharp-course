using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class clsResult
    {
        static void Main(string[] args)
        {
            String StudentID, StudentName;
            int DDOOCP, CS, SFC, DDW, TotalMark, Average;
            StudentID = "ST_00200770";
            StudentName = "Yan Linn Aung";
            DDOOCP = 80;
            CS = 90;
            SFC = 85;
            DDW = 90;
            TotalMark = DDOOCP + CS + SFC + DDW;
            Average = TotalMark / 4;
            Console.WriteLine("Student Result File");
            Console.WriteLine("StudentID\tStudentName\tDDOOCP\tCS\tSFC\tDDW\tTotalMark\tAverage");
            Console.WriteLine(StudentID + "\t" + StudentName + "\t" + DDOOCP + "\t" + CS + "\t" + SFC + "\t" + DDW + "\t" + TotalMark + "\t\t" + Average);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            const double pi = 3.14;
            int r = 3;
            double result;
            result = pi * r * r;
            Console.WriteLine("Const Result = " + result);

            Console.Read();
        }
    }
}

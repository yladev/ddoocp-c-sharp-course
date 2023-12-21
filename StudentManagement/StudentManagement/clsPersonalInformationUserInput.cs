using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class clsPersonalInformationUserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your firstName:");
            String firstName = Console.ReadLine();
            Console.Write("Please enter your lastName:");
            String lastName = Console.ReadLine();
            Console.Write("Please enter your age:");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n\n" + "Uer Name: " + firstName + "\t" + lastName + "\n" + "Age: " + age);
            Console.Read();
        }
    }
}

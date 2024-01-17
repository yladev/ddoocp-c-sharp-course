using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class clsStudents
    {
        public string StudentID, StudentName, NRC, Quali, EmailAddress, PhoneNumber, Address;

        public string Student_ID(string stuid)
        {
            StudentID = stuid;
            return StudentID;
        }

        public string Student_Name(string stuname)
        {
            StudentName = stuname;
            return StudentName;
        }

        public string Student_NRC(string stunrc)
        {
            NRC = stunrc;
            return NRC;
        }

        public string Student_Quali(string stuquali)
        {
            Quali = stuquali;
            return Quali;
        }

        public string Student_EmailAddress(string stuemailaddress)
        {
            EmailAddress = stuemailaddress;
            return EmailAddress;
        }

        public string Student_PhoneNumber(string stuphonenumber)
        {
            PhoneNumber = stuphonenumber;
            return PhoneNumber;
        }

        public string Student_Address(string stuaddress)
        {
            Address = stuaddress;
            return Address;
        }
    }
}

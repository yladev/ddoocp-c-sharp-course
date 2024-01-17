using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class clsCourse
    {
        public string CourseID, CourseName, Fees, Duration;

        public string Course_ID(string cusid)
        {
            CourseID = cusid;
            return CourseID;
        }

        //public void Course_ID(string cusid)
        //{
        //    CourseID = cusid;
        //}

        public string Course_Name(string cusname)
        {
            CourseName = cusname;
            return CourseName;
        }

        public string Course_Fees(string cusfees)
        {
            Fees = cusfees;
            return Fees;
        }

        public string Course_Duration(string cusduration)
        {
            Duration = cusduration;
            return Duration;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWA4.Models
{
    public abstract class Subjects
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int Num_Repeating_Students{ get; set; }
        public int New_Students_Num { get; set; }



        public Subjects(int subjectID, string subjectName, int num_Repeating_Students, int new_Students_Num)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            Num_Repeating_Students = num_Repeating_Students;
            New_Students_Num = new_Students_Num;

        }
        public Subjects() { }

        public abstract int EnrolledStudentsCalculation();

        public virtual double TotalEnrolledStudents()
        {
            return Num_Repeating_Students +  New_Students_Num;
        }

    }
}

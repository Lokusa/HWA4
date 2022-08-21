using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWA4.Models
{
    public class Maths : Subjects
    {
        public int Study_Unit { get; set; }
        public int HoursPerweek { get; set; }
       
        public Maths(int subjectID, string subjectName, int num_Repeating_Students, int new_Students_Num, int study_Unit, int hoursPerweek) : base(subjectID, subjectName, num_Repeating_Students, new_Students_Num)
        {
            Study_Unit = study_Unit;
            HoursPerweek = hoursPerweek;
            
        }

        public Maths()
        {

        }
        public override int EnrolledStudentsCalculation()
        {
            return 70;
        }
    }
}
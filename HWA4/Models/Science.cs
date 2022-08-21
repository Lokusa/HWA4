using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWA4.Models
{
    public class Science : Subjects
    {
        public string Study_Unit_covered { get; set; }
        public int LevelOfDifficulty { get; set; }

        

        public Science(int subjectID, string subjectName, int num_Repeating_Students, int new_Students_Num, string studyUnit_Content, int levelOfDifficulty) : base(subjectID, subjectName, num_Repeating_Students, new_Students_Num)
        {
            Study_Unit_covered = studyUnit_Content;
            LevelOfDifficulty = levelOfDifficulty;
            

        }

        public Science()
        {

        }
        public override int EnrolledStudentsCalculation()
        {
            return 15;
        }
    }
}
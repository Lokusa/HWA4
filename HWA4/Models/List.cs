using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWA4.Models
{
    public static class List
    {
        public static readonly List<Subjects> subjects = new List<Subjects>();

        

        public static List<Subjects> Subjects()
        {
            return subjects;
        }
        public static void Add(Subjects sub)
        {
            subjects.Add(sub);
        }
        
        public static void Delete(int id)
        {
            for (int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i].SubjectID == id)
                {
                    subjects.Remove(subjects[i]);
                }
            }

        }

        public static void Edit(Subjects subjects)
        {
            if (subjects.GetType() == typeof(Maths))
            {
                


            }

           

            }

        }
    }



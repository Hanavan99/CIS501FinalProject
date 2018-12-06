using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Semester
    {
        protected string semesterName;
        protected List<Section> sections;

        public Semester(string semesterName)
        {
            this.semesterName = semesterName;
        }

        public void AddSemester(Section section)
        {
            sections.Add(section);
        }

        public override bool Equals(object obj)
        {
            Semester semester = (Semester)obj;

            if(this.sections.Count != semester.sections.Count)
            {
                return false;
            }

            bool flag = true;

            for(int i = 0; i < this.sections.Count; i++)
            {
                if (!(this.sections[i].Equals(semester.Equals(semester.sections[i]))))
                {
                    flag = false;
                }
            }

            return flag;
        }
    }
}

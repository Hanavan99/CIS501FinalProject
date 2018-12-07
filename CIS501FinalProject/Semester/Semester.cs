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

        public void AddSection(Section section)
        {
            sections.Add(section);
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Semester semester = (Semester)obj;

            if (this.semesterName.Equals(semester.semesterName))
            {
                return true;
            }

            return false;
        }

        public Section Sections
        {
            get
            {
                return sections;
            }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Instructor
    {
        private string instructorName;

        public Instructor(string instructorName)
        {
            this.instructorName = instructorName;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Instructor instructor = (Instructor)obj;

            if (this.instructorName.Equals(instructor.instructorName))
            {
                return true;
            }

            return false;
        }
    }
}

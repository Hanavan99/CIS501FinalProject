using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Course
    {
        protected string unitsMinimum;
        protected string unitsMaximum;
        protected string classAssignmentComponent;

        public Course(string unitsMinimum, string unitsMaximum, string classAssignmentComponent)
        {
            this.unitsMinimum = unitsMinimum;
            this.unitsMaximum = unitsMaximum;
            this.classAssignmentComponent = classAssignmentComponent;
        }

        public override bool Equals(object obj)
        {
            Course course = (Course)obj;

            if(this.unitsMinimum.Equals(course.unitsMinimum) && this.unitsMaximum.Equals(course.unitsMaximum)
                && this.classAssignmentComponent.Equals(classAssignmentComponent))
            {
                return true;
            }

            return false;
        }
    }
}

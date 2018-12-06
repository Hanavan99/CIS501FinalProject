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
    }
}

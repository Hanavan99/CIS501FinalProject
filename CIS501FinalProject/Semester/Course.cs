using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Course
    {
        private string unitsMinimum;
        private string unitsMaximum;
        private string classAssignmentComponent;

        public Course(string unitsMinimum, string unitsMaximum, string classAssignmentComponent)
        {
            this.unitsMinimum = unitsMinimum;
            this.unitsMaximum = unitsMaximum;
            this.classAssignmentComponent = classAssignmentComponent;
        }

        public string UnitsMinimum { get => unitsMinimum; set => unitsMinimum = value; }
        public string UnitsMaximum { get => unitsMaximum; set => unitsMaximum = value; }
        public string ClassAssignmentComponent { get => classAssignmentComponent; set => classAssignmentComponent = value; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
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

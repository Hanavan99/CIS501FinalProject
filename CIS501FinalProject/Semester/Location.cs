using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Location
    {
        protected string facilityID;

        public Location(string facilityID)
        {
            this.facilityID = facilityID;
        }

        public override bool Equals(object obj)
        {
            Location location = (Location)obj;

            if (this.facilityID.Equals(location.facilityID))
            {
                return true;
            }

            return false;
        }
    }
}

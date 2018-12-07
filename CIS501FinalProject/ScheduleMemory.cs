using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject
{
    public static class ScheduleMemory
    {

        private static Semester.Semester localSemester;
        private static Semester.Semester ksisSemester;

        public static Semester.Semester LocalSemester
        {
            get
            {
                return localSemester;
            }
            set
            {
                localSemester = value;
            }
        }

        public static Semester.Semester KSISSemester
        {
            get
            {
                return ksisSemester;
            }
            set
            {
                ksisSemester = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class MeetingTime
    {
        protected string meetingStartDate;
        protected string meetingEndDate;
        protected string meetingTimeStart;
        protected string meetingTimeEnd;
        protected bool[] days = new bool[7];

        public MeetingTime(string meetingStartDate, string meetingEndDate, string meetingTimeStart, 
                            string meetingTimeEnd, bool [] days)
        {
            this.meetingStartDate = meetingStartDate;
            this.meetingEndDate = meetingEndDate;
            this.meetingTimeStart = meetingTimeStart;
            this.meetingTimeEnd = meetingTimeEnd;
            this.days = days;
        }
    }
}

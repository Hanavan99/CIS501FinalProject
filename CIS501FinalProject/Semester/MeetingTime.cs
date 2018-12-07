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

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MeetingTime meeting = (MeetingTime)obj;

            if(this.meetingStartDate.Equals(meeting.meetingStartDate) && this.meetingEndDate
                .Equals(meeting.meetingEndDate) && this.meetingTimeStart.Equals(meeting.meetingTimeStart)
                && this.meetingTimeEnd.Equals(meeting.meetingTimeEnd) && this.DayCheck(meeting))
            {
                return true;
            }

            return false;
        }

        private bool DayCheck(MeetingTime meeting)
        {
            bool flag = true;

            for(int i = 0; i < 7; i++)
            {
                if (!(this.days[i].Equals(meeting.days[i])))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}

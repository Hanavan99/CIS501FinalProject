using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class MeetingTime
    {
        private string meetingStartDate;
        private string meetingEndDate;
        private string meetingTimeStart;
        private string meetingTimeEnd;
        private bool[] days = new bool[7];

        public MeetingTime(string meetingStartDate, string meetingEndDate, string meetingTimeStart, 
                            string meetingTimeEnd, bool [] days)
        {
            this.meetingStartDate = meetingStartDate;
            this.meetingEndDate = meetingEndDate;
            this.meetingTimeStart = meetingTimeStart;
            this.meetingTimeEnd = meetingTimeEnd;
            this.days = days;
        }

        public string MeetingStartDate { get => meetingStartDate; set => meetingStartDate = value; }
        public string MeetingEndDate { get => meetingEndDate; set => meetingEndDate = value; }
        public string MeetingTimeStart { get => meetingTimeStart; set => meetingTimeStart = value; }
        public string MeetingTimeEnd { get => meetingTimeEnd; set => meetingTimeEnd = value; }
        public bool[] Days { get => days; set => days = value; }

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

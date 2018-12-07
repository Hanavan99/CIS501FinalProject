using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Section
    {
        private string subject;
        private string catalogNumber;
        private string classDescription;
        private string sectionName;
        private string consent;
        private string enrollmentCap;
        private string topicDescription;
        private Location location;
        private MeetingTime meetingTime;
        private Course course;
        private Instructor instructor;

        public Section(string subject, string catalogNumber, string courseDescription,
                        string sectionName, string consent, string enrollmentCap,
                        string topicDescription, string facilityID, string meetingStartDate, 
                        string meetingEndDate, string meetingTimeStart, string meetingTimeEnd, 
                        bool [] days,  string unitsMinimum, string unitsMaximum, 
                        string classAssignmentComponent, string instructorName)
        {
            this.subject = subject;
            this.catalogNumber = catalogNumber;
            this.courseDescription = courseDescription;
            this.sectionName = sectionName;
            this.consent = consent;
            this.enrollmentCap = enrollmentCap;
            this.topicDescription = topicDescription;
            location = new Location(facilityID);
            meetingTime = new MeetingTime(meetingStartDate, meetingEndDate, meetingTimeStart,
                                                meetingTimeEnd, days);
            course = new Course(unitsMinimum, unitsMaximum, classAssignmentComponent);
            instructor = new Instructor(instructorName);
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Section section = (Section)obj;

            if(this.subject.Equals(section.subject) && this.catalogNumber.Equals(section.catalogNumber)
                && this.courseDescription.Equals(section.courseDescription) && this.sectionName
                .Equals(section.sectionName) && this.consent.Equals(section.consent) && this.enrollmentCap
                .Equals(section.enrollmentCap) && this.topicDescription.Equals(section.topicDescription)
                && this.location.Equals(section.location) && this.meetingTime.Equals(section.meetingTime)
                && this.course.Equals(section.course) && this.instructor.Equals(section.instructor))
            {
                return true;
            }

            return false;
        }
        

    }
}
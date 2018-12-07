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
            this.classDescription = courseDescription;
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

        public string Subject { get => subject; set => subject = value; }
        public string CatalogNumber { get => catalogNumber; set => catalogNumber = value; }
        public string ClassDescription { get => classDescription; set => classDescription = value; }
        public string SectionName { get => sectionName; set => sectionName = value; }
        public string Consent { get => consent; set => consent = value; }
        public string EnrollmentCap { get => enrollmentCap; set => enrollmentCap = value; }
        public string TopicDescription { get => topicDescription; set => topicDescription = value; }
        public Location Location { get => location; set => location = value; }
        public MeetingTime MeetingTime { get => meetingTime; set => meetingTime = value; }
        public Course Course { get => course; set => course = value; }
        public Instructor Instructor { get => instructor; set => instructor = value; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Section section = (Section)obj;

            if(this.subject.Equals(section.subject) && this.catalogNumber.Equals(section.catalogNumber)
                && this.classDescription.Equals(section.classDescription) && this.sectionName
                .Equals(section.sectionName) && this.consent.Equals(section.consent) && this.enrollmentCap
                .Equals(section.enrollmentCap) && this.topicDescription.Equals(section.topicDescription))
            {
                return true;
            }

            return false;
        }
        
    }
}
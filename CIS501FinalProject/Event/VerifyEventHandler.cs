using CIS501FinalProject.File;
using CIS501FinalProject.Semester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501FinalProject.Event
{
    public class VerifyEventHandler : IEventHandler
    {
        public void HandleEvent(object[] args)
        {
            TextBox uxKSISFilePath = (TextBox)args[0];
            TextBox text = (TextBox)args[1];
            text.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uxKSISFilePath.Text = openFileDialog.FileName;
                FileLoader ksisFileLoader = new FileLoader();
                ScheduleMemory.KSISSemester = ksisFileLoader.LoadFile(uxKSISFilePath.Text);

                text.Text = CompareSemester(ScheduleMemory.LocalSemester, ScheduleMemory.KSISSemester);
            } else
            {
                text.AppendText("User cancelled operation.");
            }

            
        }

        private string CompareSemester(Semester.Semester local, Semester.Semester ksis)
        {
            StringBuilder results = new StringBuilder();
            List<Section> localSections = new List<Section>(local.Sections);
            foreach (Section section in local.Sections)
            {
                if (ksis.Sections.Contains(section))
                {
                    localSections.Remove(section);
                } else
                {
                    bool flag = false;
                    foreach (Section ksisSection in ksis.Sections)
                    {
                        if (HasSectionChanged(section, ksisSection))
                        {
                            results.Append("Section " + section.Subject + " " + section.CatalogNumber + " section " + section.SectionName + " has changed in the current semester.");
                            results.AppendLine();
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        results.Append(">> Section " + section.Subject + " " + section.CatalogNumber + " section " + section.SectionName + " is new in local semester.");
                        results.AppendLine();
                    }
                }

                //if (!section.)
            }

            foreach (Section section in ksis.Sections)
            {
                if (!local.Sections.Contains(section))
                {
                    results.Append("<< Section " + section.Subject + " " + section.CatalogNumber + " section " + section.SectionName + " not found in current semester.");
                    results.AppendLine();
                }
            }
            return results.ToString();
        }

        private bool HasSectionChanged(Section local, Section ksis)
        {
            bool sectionsMatch = local.Subject.Equals(ksis.Subject) && local.SectionName.Equals(ksis.SectionName) && local.CatalogNumber.Equals(ksis.CatalogNumber);
            return sectionsMatch && (!local.Instructor.Equals(ksis.Instructor) || !local.Consent.Equals(ksis.Consent) || !local.EnrollmentCap.Equals(ksis.EnrollmentCap) || !local.TopicDescription.Equals(ksis.TopicDescription) || !local.MeetingTime.Equals(ksis.MeetingTime) || !local.Location.Equals(ksis.Location) || !local.Course.Equals(ksis.Course));
        }
    }
}

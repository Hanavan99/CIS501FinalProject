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

        private FileLoader ksisFileLoader = new FileLoader();

        public void HandleEvent(object[] args)
        {
            TextBox uxKSISFilePath = (TextBox)args[0];
            TextBox text = (TextBox)args[1];
            text.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool showDialog = (bool)args[2];
            if (!showDialog || (showDialog && openFileDialog.ShowDialog() == DialogResult.OK))
            {
                if (showDialog)
                {
                    uxKSISFilePath.Text = openFileDialog.FileName;
                }
                ScheduleMemory.KSISSemester = ksisFileLoader.LoadFile(uxKSISFilePath.Text);

                string _text = CompareSemester(ScheduleMemory.LocalSemester, ScheduleMemory.KSISSemester);
                if (_text.Equals(""))
                {
                    text.Text = "No errors found in semester files.";
                } else
                {
                    text.Text = _text;
                }
            } else
            {
                text.AppendText("User cancelled operation.");
            }

            
        }

        private string CompareSemester(Semester.Semester local, Semester.Semester ksis)
        {
            StringBuilder results = new StringBuilder();
            List<Section> localOnlySections = new List<Section>();
            List<Section> ksisOnlySections = new List<Section>();
            List<Section> changedSections = new List<Section>();
            foreach (Section localSection in local.Sections)
            {
                if (!ksis.Sections.Contains(localSection))
                {
                    bool flag = false;
                    foreach (Section ksisSection in ksis.Sections)
                    {
                        if (HasSectionChanged(localSection, ksisSection))
                        {
                            results.Append("Section " + localSection.Subject + " " + localSection.CatalogNumber + " section " + localSection.SectionName + " has changed in the current semester.");
                            results.AppendLine();
                            changedSections.Add(localSection);
                            changedSections.Add(ksisSection);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        results.Append(">> Section " + localSection.Subject + " " + localSection.CatalogNumber + " section " + localSection.SectionName + " is new in local semester.");
                        results.AppendLine();
                        localOnlySections.Add(localSection);
                    }
                }
            }

            foreach (Section ksisSection in ksis.Sections)
            {
                if (!local.Sections.Contains(ksisSection))
                {
                    if (!changedSections.Contains(ksisSection) && localOnlySections.Contains(ksisSection))
                    {
                        results.Append("<< Section " + ksisSection.Subject + " " + ksisSection.CatalogNumber + " section " + ksisSection.SectionName + " not found in current semester.");
                        results.AppendLine();
                        ksisOnlySections.Add(ksisSection);
                    }
                }
            }
            return results.ToString();
        }

        private bool HasSectionChanged(Section local, Section ksis)
        {
            bool sectionsMatch = local.Subject.Equals(ksis.Subject) && local.SectionName.Equals(ksis.SectionName) && local.CatalogNumber.Equals(ksis.CatalogNumber);
            return sectionsMatch && (!local.Instructor.Equals(ksis.Instructor) || !local.Consent.Equals(ksis.Consent) || !local.EnrollmentCap.Equals(ksis.EnrollmentCap) || !local.TopicDescription.Equals(ksis.TopicDescription) || !local.MeetingTime.Equals(ksis.MeetingTime) || !local.Location.Equals(ksis.Location) || !local.Course.Equals(ksis.Course) || !local.ClassDescription.Equals(ksis.ClassDescription));
        }
    }
}

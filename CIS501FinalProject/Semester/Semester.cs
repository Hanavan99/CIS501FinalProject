﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Semester
    {
        private string semesterName;
        private List<Section> sections;

        public Semester(string semesterName)
        {
            this.semesterName = semesterName;
            this.sections = new List<Section>();
        }

        public void AddSection(Section section)
        {
            sections.Add(section);
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Semester semester = (Semester)obj;

            if (this.semesterName.Equals(semester.semesterName))
            {
                return true;
            }

            return false;
        }

        public List<Section> Sections
        {
            get
            {
                return sections;
            }
        }

        public string SemesterName { get => semesterName; set => semesterName = value; }
    }
}

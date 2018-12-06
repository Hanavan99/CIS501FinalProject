﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Semester
{
    public class Semester
    {
        protected string semesterName;
        protected List<Section> sections;

        public Semester(string semesterName)
        {
            this.semesterName = semesterName;
        }

        public void AddSemester(Section section)
        {
            sections.Add(section);
        }
    }
}
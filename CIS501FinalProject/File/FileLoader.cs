using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CIS501FinalProject.Semester;

namespace CIS501FinalProject.File
{
    public class FileLoader
    {

        public Semester.Semester LoadFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string semesterName = reader.ReadLine();
                reader.ReadLine(); // read CSV column header garbage
            }
            return null;
        }

    }
}

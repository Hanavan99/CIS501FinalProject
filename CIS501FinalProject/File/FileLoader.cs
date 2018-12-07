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
            Semester.Semester semester = null;
            using (reader)
            {
                string semesterName = reader.ReadLine();
                reader.ReadLine(); // read CSV column header garbage

                semester = new Semester.Semester(semesterName);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split(',');
                    bool[] days = new bool[7];
                    days[0] = columns[13].Equals("Y");
                    days[1] = columns[14].Equals("Y");
                    days[2] = columns[15].Equals("Y");
                    days[3] = columns[16].Equals("Y");
                    days[4] = columns[17].Equals("Y");
                    days[5] = columns[18].Equals("Y");
                    days[6] = columns[19].Equals("Y");
                    Section section = new Section(columns[0], columns[1], columns[2], columns[3], columns[5], columns[6], columns[7], columns[10], columns[8], columns[9], columns[11], columns[12], days, columns[20], columns[21], columns[22], columns[4]);
                    semester.AddSection(section);
                }

                return semester;
            }
            return null;
        }

    }
}

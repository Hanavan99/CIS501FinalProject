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
            FileLoader localFileLoader = new FileLoader();
            Semester.Semester semester = localFileLoader.LoadFile((string)args[0]);
            TextBox text = (TextBox) args[1];
            foreach (Section section in semester.Sections)
            {
                text.AppendText(section)
            }
        }
    }
}

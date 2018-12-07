using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501FinalProject.Event
{
    public class ClearEventHandler : IEventHandler
    {
        public void HandleEvent(object[] args)
        {
            TextBox uxLocalFilePath = (TextBox)args[0];
            TextBox uxKSISFilePath = (TextBox)args[1];
            TextBox uxResults = (TextBox)args[2];

            uxLocalFilePath.Text = "";
            uxKSISFilePath.Text = "";
            uxResults.Text = "";

            ScheduleMemory.LocalSemester = null;
            ScheduleMemory.KSISSemester = null;
        }
    }
}

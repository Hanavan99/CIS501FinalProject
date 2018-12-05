using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501FinalProject.Event
{
    public class ViewAboutEventHandler : IEventHandler
    {
        public void HandleEvent(object[] args)
        {
            MessageBox.Show("Program Name: " + ProgramInfo.ProgramName + "\n" + );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Event
{
    public class ReloadEventHandler : IEventHandler
    {
        public void HandleEvent(object[] args)
        {
            ScheduleMemory.KSISSemester = null;
            ScheduleMemory.LocalSemester = null;

            EventDispatcher.DispatchEvent("load", new object[] { args[0], false });
            EventDispatcher.DispatchEvent("verify", new object[] { args[1], args[2], false });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Event
{
    public interface IEventHandler
    {

        void HandleEvent(object[] args);

    }
}

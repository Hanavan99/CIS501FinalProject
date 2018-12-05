using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501FinalProject.Event
{
    public static class EventDispatcher
    {

        private static Dictionary<string, List<IEventHandler>> handlers = new Dictionary<string, List<IEventHandler>>();

        public static void RegisterHandler(string name, IEventHandler handler)
        {
            if (!handlers.ContainsKey(name)) {
                handlers[name] = new List<IEventHandler>();
            }
            handlers[name].Add(handler);
        }

        public static void UnregisterHandler(string name, IEventHandler handler)
        {
            if (handlers.ContainsKey(name))
            {
                handlers[name].Remove(handler);
            }
        }

        public static void DispatchEvent(string name, object[] args)
        {
            foreach (IEventHandler handler in handlers[name])
            {
                handler.HandleEvent(args);
            }
        }

    }
}

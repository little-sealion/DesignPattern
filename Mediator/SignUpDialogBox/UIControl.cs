using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.SignUpDialogBox
{
    public abstract class UIControl
    {
        private List<Action> _eventHandlers = new();
        public void AttachHandler(Action handler)
        {
            _eventHandlers.Add(handler);
        }

        protected void NotifyHandlers()
        {
            foreach (var handler in _eventHandlers)
            {
                handler();
            }
        }
    }
}
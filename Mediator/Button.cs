using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class Button : UIControl
    {
        public bool IsEnabled { get; private set; }
        public void SetEnabled(bool enabled)
        {
            IsEnabled = enabled;
            NotifyHandlers();
        }
    }
}
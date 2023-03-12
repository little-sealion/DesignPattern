using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.SignUpDialogBox
{
    public class SignUpButton : UIControl
    {
        public bool IsEnabled { get; private set; }
        public void SetEnabled(bool enable)
        {
            IsEnabled = enable;
            NotifyHandlers();
        }

    }
}
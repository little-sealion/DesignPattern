using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class Button : UIControl
    {
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled { get; private set; }
        public void SetEnabled(bool enabled)
        {
            IsEnabled = enabled;
            _owner.Changed(this);
        }
    }
}
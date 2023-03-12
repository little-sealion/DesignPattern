using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.SignUpDialogBox
{
    public class AgreeCheckBox : UIControl
    {
        public bool Checked { get; private set; }
        public void SetChecked(bool check)
        {
            Checked = check;
            NotifyHandlers();
        }

    }
}
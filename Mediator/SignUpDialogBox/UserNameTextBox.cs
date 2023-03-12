using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.SignUpDialogBox
{
    public class UserNameTextBox : UIControl
    {
        public string UserName { get; private set; }
        public void SetUserName(string userName)
        {
            UserName = userName;
            NotifyHandlers();
        }

    }
}
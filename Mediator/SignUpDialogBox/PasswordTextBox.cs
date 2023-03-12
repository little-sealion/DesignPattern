using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.SignUpDialogBox
{
    public class PasswordTextBox : UIControl
    {
        public string Password { get; private set; }
        public void SetPassword(string password)
        {
            Password = password;
            NotifyHandlers();
        }

    }
}
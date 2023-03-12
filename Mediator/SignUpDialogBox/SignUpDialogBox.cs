using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.SignUpDialogBox
{
    public class SignUpDialogBox
    {
        private UserNameTextBox _userNameTextBox = new();
        private PasswordTextBox _passwordTextBox = new();
        private AgreeCheckBox _agreeCheckBox = new();
        private SignUpButton _signUpButton = new();
        public SignUpDialogBox()
        {
            _userNameTextBox.AttachHandler(enableSignUpButton);
            _passwordTextBox.AttachHandler(enableSignUpButton);
            _agreeCheckBox.AttachHandler(enableSignUpButton);
        }

        public void SimulateUserInteraction()
        {
            System.Console.WriteLine(_signUpButton.IsEnabled);
            _userNameTextBox.SetUserName("tiaotiao");
            _passwordTextBox.SetPassword("123456");
            System.Console.WriteLine("After filling username & password: " + _signUpButton.IsEnabled);
            _agreeCheckBox.SetChecked(true);
            System.Console.WriteLine("After filling username & password & agree terms: " + _signUpButton.IsEnabled);
            _userNameTextBox.SetUserName(userName: "");
            System.Console.WriteLine("After removing username : " + _signUpButton.IsEnabled);
        }
        private void enableSignUpButton()
        {
            if (string.IsNullOrEmpty(_userNameTextBox.UserName)
            || string.IsNullOrEmpty(_passwordTextBox.Password)
            || !_agreeCheckBox.Checked)
            {
                _signUpButton.SetEnabled(false);
            }
            else
            {
                _signUpButton.SetEnabled(true);
            }
        }
    }
}
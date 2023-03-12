using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class ArticlesDialogBox
    {
        private ListBox _articleListBox = new ListBox();
        private TextBox _titleTextBox = new TextBox();
        private Button _saveButton = new Button();

        public ArticlesDialogBox()
        {
            _articleListBox.AttachHandler(articleSelected);
            _titleTextBox.AttachHandler(titleChanged);
        }

        public void SimulateUserInteraction()
        {
            _articleListBox.SetSelection("Article 1");
            System.Console.WriteLine("TextBox: " + _titleTextBox.Content);
            System.Console.WriteLine("Button: " + _saveButton.IsEnabled);
            _titleTextBox.SetContent("");
            System.Console.WriteLine("TextBox: " + _titleTextBox.Content);
            System.Console.WriteLine("Button: " + _saveButton.IsEnabled);
            _titleTextBox.SetContent("Article 2");
            System.Console.WriteLine("TextBox: " + _titleTextBox.Content);
            System.Console.WriteLine("Button: " + _saveButton.IsEnabled);
        }



        private void titleChanged()
        {
            var isEmpty = string.IsNullOrEmpty(_titleTextBox.Content);
            _saveButton.SetEnabled(!isEmpty);
        }

        private void articleSelected()
        {
            _titleTextBox.SetContent(_articleListBox.Selection);
            _saveButton.SetEnabled(true);
        }
    }
}
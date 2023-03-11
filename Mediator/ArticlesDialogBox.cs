using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox _articleListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public ArticlesDialogBox()
        {
            _articleListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
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

        public override void Changed(UIControl control)
        {
            if (control == _articleListBox)
            {
                articleSelected();
            }
            else if (control == _titleTextBox)
            {
                titleChanged();
            }
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
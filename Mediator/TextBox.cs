using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class TextBox : UIControl
    {
        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string Content { get; private set; }
        public void SetContent(string content)
        {
            Content = content;
            _owner.Changed(this);
        }
    }
}
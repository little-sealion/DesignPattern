using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class ListBox : UIControl
    {
        public ListBox(DialogBox owner) : base(owner)
        {
        }
        public string Selection { get; private set; }
        public void SetSelection(string selection)
        {
            Selection = selection;
            _owner.Changed(this);
        }
    }

}
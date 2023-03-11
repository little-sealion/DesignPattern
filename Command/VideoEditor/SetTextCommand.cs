using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.VideoEditor
{
    public class SetTextCommand : AbstractUndoableCommand
    {
        private string _prevText;
        private string _text;

        public SetTextCommand(string text, Video video, History history) : base(video, history)
        {
            _text = text;
        }

        protected override void DoExecute()
        {
            _prevText = _video.Text;
            _video.SetText(_text);
        }

        protected override void DoUnexecute()
        {
            _video.SetText(_prevText);
        }
    }
}
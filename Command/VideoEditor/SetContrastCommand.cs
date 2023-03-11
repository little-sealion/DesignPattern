using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.Command.Editor;

namespace DesignPattern.Command.VideoEditor
{
    public class SetContrastCommand : AbstractUndoableCommand
    {
        private float _prevContrast;
        private float _contrast;

        public SetContrastCommand(float contrast, Video video, History history) : base(video, history)
        {
            _contrast = contrast;
        }

        protected override void DoExecute()
        {
            _prevContrast = _video.Contrast;
            _video.SetContrast(_contrast);
        }

        protected override void DoUnexecute()
        {
            _video.SetContrast(_prevContrast);
        }
    }
}
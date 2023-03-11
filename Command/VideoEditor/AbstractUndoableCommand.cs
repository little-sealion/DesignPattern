using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.VideoEditor
{
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        protected Video _video;
        protected History _history;


        public AbstractUndoableCommand(Video video, History history)
        {
            _video = video;
            _history = history;
        }

        public void Execute()
        {
            DoExecute();
            _history.Push(this);
        }

        public void Unexecute()
        {
            DoUnexecute();
        }

        protected abstract void DoUnexecute();
        protected abstract void DoExecute();
    }
}
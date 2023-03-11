using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.VideoEditor
{
    public class History
    {
        private Stack<IUndoableCommand> _commands = new();

        public void Push(IUndoableCommand command)
        {
            _commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return _commands.Pop();
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.VideoEditor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
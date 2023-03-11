using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command.Editor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexcute();
    }
}
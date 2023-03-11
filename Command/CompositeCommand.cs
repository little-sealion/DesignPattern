using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> _commands = new();
        public void Add(ICommand command)
        {
            _commands.Add(command);
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
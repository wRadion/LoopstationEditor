using System;
using System.Windows.Input;

namespace LoopstationEditor.Commands
{
    public class IntCommand : ICommand
    {
        private readonly Action<int> _action;

        public event EventHandler CanExecuteChanged;

        public IntCommand(Action<int> action) => _action = action;

        public bool CanExecute(object _) => true;

        public void Execute(object parameter) => _action(Convert.ToInt32(parameter));
    }
}

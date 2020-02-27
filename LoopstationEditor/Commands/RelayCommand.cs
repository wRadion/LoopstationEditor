using System;
using System.Windows.Input;

namespace LoopstationEditor.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action action) => _action = action;

        public bool CanExecute(object _) => true;

        public void Execute(object _) => _action();
    }
}

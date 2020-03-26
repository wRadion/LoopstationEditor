using System;
using System.Windows.Input;

namespace LoopstationEditor.Commands
{
    public class Command<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public Command(Action<T> execute) : this(execute, (_) => true) { }
        public Command(Action<T> execute, Func<T, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute((T)Convert.ChangeType(parameter, typeof(T)));
        public void Execute(object parameter) => _execute((T)Convert.ChangeType(parameter, typeof(T)));

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}

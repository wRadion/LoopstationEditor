using System;
using System.Windows.Input;

namespace LoopstationEditor.Commands
{
    public class Command<T, U> : ICommand
    {
        private readonly Action<T, U> _execute;
        private readonly Func<T, U, bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public Command(Action<T, U> execute) : this(execute, (_, __) => true) { }
        public Command(Action<T, U> execute, Func<T, U, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter is object[] args && args.Length == 2)
            {
                T arg1 = (T)Convert.ChangeType(args[0], typeof(T));
                U arg2 = (U)Convert.ChangeType(args[1], typeof(U));

                return _canExecute(arg1, arg2);
            }
            else
                throw new ArgumentException("An object of two arguments was expected.");

        }

        public void Execute(object parameter)
        {
            if (parameter is object[] args && args.Length == 2)
            {
                T arg1 = (T)Convert.ChangeType(args[0], typeof(T));
                U arg2 = (U)Convert.ChangeType(args[1], typeof(U));

                _execute(arg1, arg2);
            }
            else
                throw new ArgumentException("An object of two arguments was expected.");
        }

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}

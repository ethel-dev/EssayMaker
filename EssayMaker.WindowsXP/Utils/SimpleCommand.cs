using System;
using System.Windows.Input;

namespace EssayMaker.Windows
{
    public class SimpleCommand : ICommand
    {
        public Predicate<object> Condition { get; set; }
        public Action<object> Action { get; set; }

        public SimpleCommand()
        {
            
        }

        public SimpleCommand(Action action)
        {
            this.Action = x => action();
        }

        public bool CanExecute(object parameter)
        {
            if (Condition != null)
                return Condition(parameter);
            return true; // if there is no can execute default to true
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            if (Action != null)
                Action(parameter);
        }
    }
}
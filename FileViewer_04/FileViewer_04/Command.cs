using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileViewer_04
{
    class Command : ICommand
    {
        Action<object> DoSomething;
        // Func<object, bool> ToDoOrNot;

        public Command(Action<object> DoSomething)
        {
            this.DoSomething = DoSomething;
            // this.ToDoOrNot = ToDoOrNot;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoSomething(parameter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FIleViewer_05.Command
{
    public class Command : ICommand
    {
        Action<object> readWriteFile;

        public Command(Action<object> readWriteFile)
        {
            this.readWriteFile = readWriteFile;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            readWriteFile(parameter);
        }
    }
}

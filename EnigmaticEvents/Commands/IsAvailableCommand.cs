using EnigmaticEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnigmaticEvents.Commands
{
    public class IsAvailableCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return parameter is EventContact;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}

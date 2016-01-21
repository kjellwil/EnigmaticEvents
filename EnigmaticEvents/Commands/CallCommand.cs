using EnigmaticEvents.Models;
using System;
using System.Windows.Input;
using Windows.ApplicationModel.Calls;

namespace EnigmaticEvents.Commands
{
    public class CallCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return parameter is EventContact;
        }

        public async void Execute(object parameter)
        {
            var contact = parameter as EventContact;
            var lines = await PhoneCallManager.RequestStoreAsync();
            var id = await lines.GetDefaultLineAsync();
            var line = await PhoneLine.FromIdAsync(id);

            line.Dial(contact.PhoneNumber, contact.Name);
        }
    }
}

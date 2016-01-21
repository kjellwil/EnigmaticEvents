using EnigmaticEvents.Common;
using EnigmaticEvents.Interfaces;
using EnigmaticEvents.Models;
using EnigmaticEvents.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace EnigmaticEvents.ViewModels
{
    public class EventViewModel : BindableBase
    {
        public EventViewModel(IProvideEventData eventProvider)
        {
            LoadEvents(eventProvider);
        }

        private async void LoadEvents(IProvideEventData provider)
        {
            Events = await provider.GetEventsAsync();
            CurrentEvent = Events.FirstOrDefault();
        }

        public ICommand SendSmsCommand => new RelayCommand<string>((message) =>
        {
            SmsUtils.SendSmsAsync(message, SelectedItems as List<object>);
        });

        public ICommand SelectionChangedCommand => new RelayCommand<List<EventContact>>((param) =>
        {
            SelectedItems = param;
        });
        private List<EnigmaEvent> _events;

        public List<EnigmaEvent> Events
        {
            get
            {
                return _events;
            }

            set
            {
                _events = value;
                OnPropertyChanged();
            }
        }

        public EnigmaEvent CurrentEvent
        {
            get
            {
                return _currentEvent;
            }

            set
            {
                _currentEvent = value;
                OnPropertyChanged();
            }
        }

        public bool ShowCommands
        {
            get
            {
                return _showCommands;
            }

            set
            {
                _showCommands = value;
                OnPropertyChanged();
            }
        }

        public object SelectedItems
        {
            get
            {
                return _selectedItems;
            }

            set
            {
                _selectedItems = value;
                OnPropertyChanged();
                if(_selectedItems != null)
                {
                    ShowCommands = true;
                }
                else
                {
                    ShowCommands = false;
                }
            }
        }

        public object SelectedGroup
        {
            get
            {
                return _selectedGroup;
            }

            set
            {
                _selectedGroup = value;
                SelectedItems = null;
                OnPropertyChanged();
            }
        }

        private EnigmaEvent _currentEvent;

        private bool _showCommands;

        private object _selectedItems;
        private object _selectedGroup;
    }
}

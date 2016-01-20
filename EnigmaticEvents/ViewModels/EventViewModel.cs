using EnigmaticEvents.Common;
using EnigmaticEvents.Interfaces;
using EnigmaticEvents.Models;
using System.Collections.Generic;
using System.Linq;

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

        private IList<EnigmaEvent> _events;

        public IList<EnigmaEvent> Events
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

        private EnigmaEvent _currentEvent;
    }
}

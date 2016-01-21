using EnigmaticEvents.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaticEvents.Models
{
    public class EnigmaEvent : BindableBase
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private string _description;

        public List<AgendaItem> Agenda { get; set; }
        public List<Team> Teams { get; set; }

        public List<EventContact> Contacts { get; set; }

    }
}

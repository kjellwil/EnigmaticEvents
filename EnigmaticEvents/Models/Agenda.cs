using EnigmaticEvents.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaticEvents.Models
{
    public class Agenda : BindableBase
    {
        public DateTime Time { get; set; }
        public List<AgendaItem> AgendaItems { get; set; }
    }
}

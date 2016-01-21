using EnigmaticEvents.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaticEvents.Models
{
    public class AgendaItem : BindableBase
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}

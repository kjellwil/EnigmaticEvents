using EnigmaticEvents.Common;
using System.Collections.Generic;

namespace EnigmaticEvents.Models
{
    public class Team : BindableBase
    {
        public string Name { get; set; }
        public List<Participant> Members { get; set; }
    }
}
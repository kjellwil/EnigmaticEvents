using EnigmaticEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaticEvents.Interfaces
{
    public interface IProvideEventData
    {
        Task<List<EnigmaEvent>> GetEventsAsync();
    }
}

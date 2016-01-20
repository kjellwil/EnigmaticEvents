using EnigmaticEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaticEvents.Models;

namespace EnigmaticEvents.Services
{
    public class EventProvider : IProvideEventData
    {
        public Task<List<EnigmaEvent>> GetEventsAsync()
        {
            var events = new List<EnigmaEvent>
            {
                new EnigmaEvent
                {
                    Name = "Teambuilding 2016",
                    Description = "We do some business stuff then we dress up in togas and go nuts!",
                    Agenda = new List<AgendaItem>
                    {
                        new AgendaItem { Name = "Introduction" },
                        new AgendaItem { Name = "Drink!" }
                    }

                },
                new EnigmaEvent
                {
                    Name = "Partytime excellent",
                    Agenda = new List<AgendaItem>
                    {
                        new AgendaItem { Name = "Boring stuff" },
                        new AgendaItem { Name = "Drink!" }
                    }
                }
            };
            return Task.FromResult(events);
        }
    }
}

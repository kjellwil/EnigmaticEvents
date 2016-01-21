using EnigmaticEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaticEvents.Models;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnigmaticEvents.Services
{
    public class EventProvider : IProvideEventData
    {
        public Task<List<EnigmaEvent>> GetEventsAsync()
        {
            var events = LoadFromSampleData();
            return Task.FromResult(events);
        }

        private List<EnigmaEvent> LoadFromSampleData()
        {
            using (var file = File.OpenText("./DesignTime/sampledata.json"))
            {
                using (var reader = new JsonTextReader(file))
                {
                    var jArray = (JArray)JToken.ReadFrom(reader);
                    var events = jArray.ToObject<List<EnigmaEvent>>();
                    return events;
                }
            }
        }
    }
}

using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JamSesh.Models
{
    public class Jam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public int MaxNumberOfAttendees { get; set; }
        public string Image { get; set; }

        public virtual JamAttendees Attendees { get; set; }

        public int ProfileId { get; set; }

        [JsonIgnore]
        public virtual Profile CreatorProfile { get; set; }

    }
}

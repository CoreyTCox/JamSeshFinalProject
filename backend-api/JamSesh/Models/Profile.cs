using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Instruments { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public virtual List<Jam> JamsAttending { get; set; }

    }
}

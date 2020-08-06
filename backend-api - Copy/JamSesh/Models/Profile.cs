using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public string Instruments { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        [Required]
        public string Password { get; set; }


        public virtual IList<ProfileJam> JamsAttending { get; set; }

    }
}

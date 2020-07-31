using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Models
{
    public class JamAttendees
    {
        public virtual List<Profile> Attendees { get; set; } = new List<Profile>();

        public int Id { get; set; }



    }
}

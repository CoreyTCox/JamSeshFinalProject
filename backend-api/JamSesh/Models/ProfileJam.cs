using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Models
{
    public class ProfileJam
    {
        public int JamID { get; set; }
        public virtual Jam Jam { get; set; }


        public int ProfileID { get; set; }
        public virtual Profile Profile { get; set; }


    }
}

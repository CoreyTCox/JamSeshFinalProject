using JamSesh.Context;
using JamSesh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Repositories
{
    public class ProfileRepository : Repository<Profile>, IRepository<Profile>
    {
        public ProfileRepository(JamSeshContext context) : base(context)
        {
        }
    }
}

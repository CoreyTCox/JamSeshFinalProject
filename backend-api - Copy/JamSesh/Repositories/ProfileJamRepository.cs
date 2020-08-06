using JamSesh.Context;
using JamSesh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Repositories
{
    public class ProfileJamRepository : Repository<ProfileJam>, IRepository<ProfileJam>
    {
        public ProfileJamRepository(JamSeshContext context) : base(context)
        {

        }
    }
}

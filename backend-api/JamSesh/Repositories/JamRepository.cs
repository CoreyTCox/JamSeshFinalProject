using JamSesh.Context;
using JamSesh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Repositories
{
    public class JamRepository : Repository<Jam>, IRepository<Jam>
    {
        public JamRepository(JamSeshContext context) : base(context)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JamSesh.Models;
using JamSesh.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JamSesh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileJamController : ControllerBase
    {
        private JamSesh.Repositories.IRepository<ProfileJam> profileJamRepo;

        public ProfileJamController(IRepository<ProfileJam> profileJamRepo)
        {

            this.profileJamRepo = profileJamRepo;

        }
        // GET: api/JamAttendees
        [HttpGet]
        public IEnumerable<ProfileJam> Get()
        {
            return profileJamRepo.GetAll();
        }

        // GET: api/JamAttendees/5
        [HttpGet("{id}")]
        public ProfileJam Get(int id)
        {
            ProfileJam jamAttendees = profileJamRepo.GetById(id);
            return jamAttendees;
        }

        // POST: api/JamAttendees
        [HttpPost]
        public IEnumerable<ProfileJam> Post([FromBody] ProfileJam value)
        {
            profileJamRepo.Create(value);
            return profileJamRepo.GetAll();
        }

        // PUT: api/JamAttendees/5
        [HttpPut("{id}")]
        public ProfileJam Put([FromBody] ProfileJam inputValue)
        {
            profileJamRepo.Update(inputValue);
            return profileJamRepo.GetAll().FirstOrDefault(x => x.JamID == inputValue.JamID && x.ProfileID == inputValue.ProfileID);

        }
    
         // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<ProfileJam> Delete(int id)
        {
            ProfileJam profilejam = profileJamRepo.GetById(id);
            profileJamRepo.Delete(profilejam);
            return profileJamRepo.GetAll();
        }
    }
}

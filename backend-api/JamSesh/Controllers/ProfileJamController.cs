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

            int existingItemCount = profileJamRepo.GetAll().Count(x => x.JamID == value.JamID && x.ProfileID == value.ProfileID);
            bool alreadyExists = existingItemCount > 0;

            if (!alreadyExists)
                profileJamRepo.Create(value);

            return profileJamRepo.GetAll().Where(x => x.JamID == value.JamID);
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

        // DELETE: api/ApiWithActions/5/1
        [HttpDelete("{jamId}/{profileId}")]
        public IEnumerable<ProfileJam> Delete(int jamId, int profileId)
        {
            ProfileJam profilejam = profileJamRepo.GetAll().FirstOrDefault(x => x.JamID == jamId && x.ProfileID == profileId);

            profileJamRepo.Delete(profilejam);
            return profileJamRepo.GetAll().Where(x => x.JamID == jamId);
        }

    }
}

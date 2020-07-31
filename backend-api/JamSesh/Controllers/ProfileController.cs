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
    public class ProfileController : ControllerBase
    {
        private JamSesh.Repositories.IRepository<Profile> profileRepo;

        public ProfileController(IRepository<Profile> profileRepo)
        {

            this.profileRepo = profileRepo;

        }

        // GET: api/Profile
        [HttpGet]
        public IEnumerable<Profile> Get()
        {
            return profileRepo.GetAll();
        }

        // GET: api/Profile/5
        [HttpGet("{id}")]
        public Profile Get(int id)
        {
            Profile profile = profileRepo.GetById(id);
            return profile;
        }

        // POST: api/Profile
        [HttpPost]
        public IEnumerable<Profile> Post([FromBody] Profile value)
        {
            profileRepo.Create(value);
            return profileRepo.GetAll();
        }

        // PUT: api/Profile/5
        [HttpPut("{id}")]
        public IEnumerable<Profile> Put([FromBody] Profile value)
        {
            profileRepo.Update(value);
            return profileRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Profile> Delete(int id)
        {
            var profile = profileRepo.GetById(id);
            profileRepo.Delete(profile);
            return profileRepo.GetAll();
        }
    }
}


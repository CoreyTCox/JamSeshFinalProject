using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JamSesh.Models;
using JamSesh.Repositories;

namespace JamSesh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JamController : ControllerBase
    {
        private JamSesh.Repositories.IRepository<Jam> jamRepo;

        public JamController(IRepository<Jam> jamRepo)
        {

            this.jamRepo = jamRepo;

        }

        // GET: api/Jam
        [HttpGet]
        public IEnumerable<Jam> Get()
        {
            return jamRepo.GetAll();
        }

        // GET: api/Jam/5
        [HttpGet("{id}")]
        public Jam Get(int id)
        {
            Jam jam = jamRepo.GetById(id);
            return jam;
        }

        // POST: api/Jam
        [HttpPost]
        public IEnumerable<Jam> Post([FromBody] Jam value)
        {
            jamRepo.Create(value);
            return jamRepo.GetAll();
        }

        // PUT: api/Jam/5
        [HttpPut("{id}")]
        public Jam Put([FromBody] Jam value)
        {
            Jam existingJam = jamRepo.GetById(value.JamId);
            existingJam.Name = value.Name;
            existingJam.Description = value.Description;
            existingJam.MaxNumberOfAttendees = value.MaxNumberOfAttendees;
            existingJam.EventDate = value.EventDate;

            jamRepo.Update(existingJam);
            return jamRepo.GetById(value.JamId);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Jam> Delete(int id)
        {
            var jam = jamRepo.GetById(id);
            jamRepo.Delete(jam);
            return jamRepo.GetAll();
        }
    }
}

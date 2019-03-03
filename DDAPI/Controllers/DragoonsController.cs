using DDAPI.Models;
using DDAPI.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace DDAPI.Controllers
{
    [Route("api/dragoons")]
    [ApiController]
    public class DragoonsController : ControllerBase
    {
        private readonly ICreatureRepo _repo;

        public DragoonsController(ICreatureRepo repo, IConfiguration configuration)
        {
            _repo = repo;
        }

        [HttpGet]
        public List<Creatures> GetCreatures()
        {
            var creatures = _repo.GetCreatures();
            return creatures;
        }

        [HttpGet("{id}")]
        public Creatures GetCreatureById(int id)
        {
            var creature = _repo.GetCreatureById(id);
            return creature;
        }

        [HttpGet]
        [Route("groups")]
        public List<Groups> GetGroups()
        {
            var groups = _repo.GetGroups();
            return groups;
        }
    }
}

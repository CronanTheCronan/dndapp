using DDAPI.Data;
using DDAPI.Models;
using System.Collections.Generic;

namespace DDAPI.Repos
{
    public class CreatureRepo : ICreatureRepo
    {
        private readonly IDragoonsContext _context;

        public CreatureRepo(DragoonsContext context)
        {
            _context = context;
        }

        public List<Creatures> GetCreatures()
        {
            return _context.GetCreatures();
        }

        public Creatures GetCreatureById(int id)
        {
            return _context.GetCreatureById(id);
        }

        public List<Groups> GetGroups()
        {
            return _context.GetGroups();
        }
    }
}

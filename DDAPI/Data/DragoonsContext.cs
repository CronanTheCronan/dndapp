using DDAPI.Models;
using DDAPI.Models.Other;
using Microsoft.EntityFrameworkCore;
using OrderApi.DataAccess.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace DDAPI.Data
{
    public class DragoonsContext : DbContext, IDragoonsContext
    {
        private DbSet<IdIntModel> IntIdDbSet { get; set; }
        private DbSet<Creatures> CreatureDbSet { get; set; }
        private DbSet<Groups> GroupDbSet { get; set; }

        public DragoonsContext(DbContextOptions<DragoonsContext> options) : base(options) { }

        private IEnumerable<int> GetIds(string storedProcedure)
        {
            return IntIdDbSet
                .FromSql(SqlContextHelper.BuildSprocString(storedProcedure))
                .ToList().Select(x => x.Id).ToList();
        }

        public List<Creatures> GetCreatures()
        {
            var creatures = GetIds("spCreaturesRetrieve");
            return creatures.Select(id => CreatureDbSet.Find(id)).ToList();
        }

        public Creatures GetCreatureById(int id)
        {
            return CreatureDbSet.Find(id);
        }

        public List<Groups> GetGroups()
        {
            var groups = GetIds("spGroupsRetrieve");
            return groups.Select(id => GroupDbSet.Find(id)).ToList();
        }
    }
}

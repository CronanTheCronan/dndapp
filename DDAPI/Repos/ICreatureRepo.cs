using DDAPI.Models;
using System.Collections.Generic;

namespace DDAPI.Repos
{
    public interface ICreatureRepo
    {
        List<Creatures> GetCreatures();
        Creatures GetCreatureById(int id);
        List<Groups> GetGroups();
    }
}
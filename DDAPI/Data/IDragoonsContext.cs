using DDAPI.Models;
using System.Collections.Generic;

namespace DDAPI.Data
{
    public interface IDragoonsContext
    {
        List<Creatures> GetCreatures();
        Creatures GetCreatureById(int id);
        List<Groups> GetGroups();
    }
}
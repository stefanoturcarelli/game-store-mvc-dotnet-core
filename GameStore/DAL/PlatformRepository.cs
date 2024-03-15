using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entities;

namespace DAL
{
    public class PlatformRepository
    {
        GameStoreContext gameStoreContext = new GameStoreContext();

        public List<Platform> GetAllPlatformsRepository()
        {
            return gameStoreContext.Platforms.ToList();
        }
        public Platform? GetPlatformByIdRepository(int PlatformId)
        {
            return gameStoreContext.Platforms.Where(x => x.PlatformId == PlatformId).FirstOrDefault();
        }
    }
}

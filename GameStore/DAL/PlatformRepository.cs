using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entities;
using Entities.Entities.DTO;

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
        public GameStoreResponse CreatePlatformRepository(Platform p)
        {

            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product ON");
                gameStoreContext.Platforms.Add(p);
                gameStoreContext.SaveChanges();
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product OFF");

                transaction.Commit();
            }
            return new GameStoreResponse();
        }
        public GameStoreResponse EditPlatformRepository(Platform p)
        {
            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                Platform? p2 = gameStoreContext.Platforms.Where(x => x.PlatformId == p.PlatformId).FirstOrDefault();
                if (p2 != null)
                {
                    p2.PlatformName = p.PlatformName;
                    gameStoreContext.SaveChanges();

                    transaction.Commit();
                    return new GameStoreResponse();
                }
            }
            return new GameStoreResponse("Edit failed: Cannot find Platform with id " + p.PlatformId);
        }
        public GameStoreResponse DeletePlatformRepository(int PlatformId)
        {
            Platform? p = gameStoreContext.Platforms.Where(x => x.PlatformId == PlatformId).FirstOrDefault();
            if (p != null)
            {
                gameStoreContext.Platforms.Remove(p);
                gameStoreContext.SaveChanges();
                return new GameStoreResponse();
            }
            return new GameStoreResponse("Delete failed: Cannot find Platform with id " + PlatformId);
        }
    }
}

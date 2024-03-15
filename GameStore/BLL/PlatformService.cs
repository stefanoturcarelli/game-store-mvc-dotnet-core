using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Entities;
using Entities.Entities.DTO;

namespace BLL
{
    public class PlatformService
    {
        PlatformRepository platformRepository = new PlatformRepository();
        public List<Platform> GetAllPlatformsService()
        {
            return platformRepository.GetAllPlatformsRepository();
        }
        public Platform? GetPlatformByIdService(int PlatformId)
        {
            return platformRepository.GetPlatformByIdRepository(PlatformId);
        }
        public GameStoreResponse CreatePlatformService(Platform p)
        {
            //if (validation)
            //{
                return platformRepository.CreatePlatformRepository(p);
            //}
            return new GameStoreResponse("Create failed: Validation error");
        }
        public GameStoreResponse EditPlatformService(Platform p)
        {
            //if (validation)
            //{
                return platformRepository.EditPlatformRepository(p);
            //}
            return new GameStoreResponse("Edit failed: Validation error");
        }
        public GameStoreResponse DeletePlatformService(int PlatformId)
        {
            return platformRepository.DeletePlatformRepository(PlatformId);
        }
    }
}

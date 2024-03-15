using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Entities;

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
    }
}

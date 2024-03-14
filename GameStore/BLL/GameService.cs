using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Entities;

namespace BLL
{
    public class GameService
    {
        GameRepository gameRepository = new GameRepository();
        public List<Game> GetAllGamesService()
        {
            return gameRepository.GetAllGamesRepository();
        }

    }
}

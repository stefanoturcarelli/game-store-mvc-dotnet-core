using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Entities;
using Entities.Entities.DTO.GameFilter;

namespace BLL
{
    public class GameService
    {
        GameRepository gameRepository = new GameRepository();
        public List<Game> GetAllGamesService()
        {
            return gameRepository.GetAllGamesRepository();
        }
        public Game? GetGameByIdService(int GameId)
        {
            return gameRepository.GetGameByIdRepository(GameId);
        }

        public List<Game> GetAllGamesByFilterService(IGameFilter gameFilter)
        {
            return gameRepository.GetAllGamesByFilterRepository(gameFilter);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entities;
using Entities.Context;
using Entities.Entities.DTO.GameFilter;

namespace DAL
{
    public class GameRepository
    {
        GameStoreContext gameStoreContext = new GameStoreContext();

        public List<Game> GetAllGamesRepository()
        {
            return gameStoreContext.Games.ToList();
        }
        public Game? GetGameByIdRepository(int GameId)
        {
            return gameStoreContext.Games.Where(x => x.GameId == GameId).FirstOrDefault();
        }

        public List<Game> GetAllGamesByFilterRepository(IGameFilter gameFilter)
        {
            return gameFilter.Filter(gameStoreContext.Games).ToList();
        }
    }
}

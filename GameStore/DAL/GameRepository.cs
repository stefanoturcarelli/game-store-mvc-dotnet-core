using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entities;
using Entities.Context;

namespace DAL
{
    public class GameRepository
    {
        GameStoreContext gameStoreContext = new GameStoreContext();

        public List<Game> GetAllGamesRepository()
        {
            return gameStoreContext.Games.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entities;
using Entities.Context;
using Entities.Entities.DTO.GameFilter;
using Entities.Entities.DTO;

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
        public GameStoreResponse CreateGameRepository(Game g)
        {

            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product ON");
                gameStoreContext.Games.Add(g);
                gameStoreContext.SaveChanges();
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product OFF");

                transaction.Commit();
            }
            return new GameStoreResponse();
        }
        public GameStoreResponse EditGameRepository(Game g)
        {
            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                Game? g2 = gameStoreContext.Games.Where(x => x.GameId == g.GameId).FirstOrDefault();
                if (g2 != null)
                {
                    g2.GameName = g.GameName;
                    g2.PublisherId = g.PublisherId;
                    g2.PlatformId = g.PlatformId;
                    g2.GameDescription = g.GameDescription;
                    g2.GenreId = g.GenreId;
                    g2.Price = g.Price;
                    g2.ReleaseDate = g.ReleaseDate;
                    gameStoreContext.SaveChanges();

                    transaction.Commit();
                    return new GameStoreResponse();
                }
            }
            return new GameStoreResponse("Edit failed: Cannot find Game with id " + g.GameId);
        }
        public GameStoreResponse DeleteGameRepository(int GameId)
        {
            Game? g = gameStoreContext.Games.Where(x => x.GameId == GameId).FirstOrDefault();
            if (g != null)
            {
                gameStoreContext.Games.Remove(g);
                gameStoreContext.SaveChanges();
                return new GameStoreResponse();
            }
            return new GameStoreResponse("Delete failed: Cannot find Game with id " + GameId);
        }

        public List<Game> GetAllGamesByFilterRepository(IGameFilter gameFilter)
        {
            return gameFilter.Filter(gameStoreContext.Games).ToList();
        }
    }
}

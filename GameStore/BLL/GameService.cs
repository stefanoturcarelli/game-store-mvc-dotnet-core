using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Entities;
using Entities.Entities.DTO;
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
        public GameStoreResponse CreateGameService(Game g)
        {
            //if (validation)
            //{
                return gameRepository.CreateGameRepository(g);
            //}
            return new GameStoreResponse("Create failed: Validation error");
        }
        public GameStoreResponse EditGameService(Game g)
        {
            //if (validation)
            //{
                return gameRepository.EditGameRepository(g);
            //}
            return new GameStoreResponse("Edit failed: Validation error");
        }
        public GameStoreResponse DeleteGameService(int GameId)
        {
            return gameRepository.DeleteGameRepository(GameId);
        }

        public List<Game> GetAllGamesByFilterService(IGameFilter gameFilter)
        {
            return gameRepository.GetAllGamesByFilterRepository(gameFilter);
        }

    }
}

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
    public class GenreRepository
    {
        GameStoreContext gameStoreContext = new GameStoreContext();

        public List<Genre> GetAllGenresRepository()
        {
            return gameStoreContext.Genres.ToList();
        }
        public Genre? GetGenreByIdRepository(int GenreId)
        {
            return gameStoreContext.Genres.Where(x => x.GenreId == GenreId).FirstOrDefault();
        }
        public GameStoreResponse CreateGenreRepository(Genre g)
        {

            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product ON");
                gameStoreContext.Genres.Add(g);
                gameStoreContext.SaveChanges();
                //pme.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Product OFF");

                transaction.Commit();
            }
            return new GameStoreResponse();
        }
        public GameStoreResponse EditGenreRepository(Genre g)
        {
            using (var transaction = gameStoreContext.Database.BeginTransaction())
            {
                Genre? g2 = gameStoreContext.Genres.Where(x => x.GenreId == g.GenreId).FirstOrDefault();
                if (g2 != null)
                {
                    g2.GenreName = g.GenreName;
                    gameStoreContext.SaveChanges();

                    transaction.Commit();
                    return new GameStoreResponse();
                }
            }
            return new GameStoreResponse("Edit failed: Cannot find Genre with id " + g.GenreId);
        }
        public GameStoreResponse DeleteGenreRepository(int GenreId)
        {
            Genre? g = gameStoreContext.Genres.Where(x => x.GenreId == GenreId).FirstOrDefault();
            if (g != null)
            {
                gameStoreContext.Genres.Remove(g);
                gameStoreContext.SaveChanges();
                return new GameStoreResponse();
            }
            return new GameStoreResponse("Delete failed: Cannot find Genre with id " + GenreId);
        }
    }
}

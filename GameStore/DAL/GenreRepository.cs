using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entities;

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
    }
}

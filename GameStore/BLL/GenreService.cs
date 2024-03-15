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
    public class GenreService
    {
        GenreRepository genreRepository = new GenreRepository();
        public List<Genre> GetAllGenresService()
        {
            return genreRepository.GetAllGenresRepository();
        }
        public Genre? GetGenreByIdService(int GenreId)
        {
            return genreRepository.GetGenreByIdRepository(GenreId);
        }
        public GameStoreResponse CreateGenreService(Genre g)
        {
            //if (validation)
            //{
                return genreRepository.CreateGenreRepository(g);
            //}
            return new GameStoreResponse("Create failed: Validation error");
        }
        public GameStoreResponse EditGenreService(Genre g)
        {
            //if (validation)
            //{
                return genreRepository.EditGenreRepository(g);
            //}
            return new GameStoreResponse("Edit failed: Validation error");
        }
        public GameStoreResponse DeleteGenreService(int GenreId)
        {
            return genreRepository.DeleteGenreRepository(GenreId);
        }
    }
}

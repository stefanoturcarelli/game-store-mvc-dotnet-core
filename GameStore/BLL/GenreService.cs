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
            TrimGenre(g);
            GameStoreResponse validation = this.ValidateGenre(g);
            if (validation.Success)
            {
                return genreRepository.CreateGenreRepository(g);
            }
            validation.Message = "Create failed: " + validation.Message;
            return validation;
        }
        public GameStoreResponse EditGenreService(Genre g)
        {
            TrimGenre(g);
            GameStoreResponse validation = this.ValidateGenre(g);
            if (validation.Success)
            {
                return genreRepository.EditGenreRepository(g);
            }
            validation.Message = "Edit failed: " + validation.Message;
            return validation;
        }
        public GameStoreResponse DeleteGenreService(int GenreId)
        {
            return genreRepository.DeleteGenreRepository(GenreId);
        }
        /// <summary>
        /// Removes extra whitespace around the edges of this object's properties
        /// </summary>
        private void TrimGenre(Genre g)
        {
            g.GenreName = g.GenreName.Trim();
        }
        private GameStoreResponse ValidateGenre(Genre g)
        {
            if (g.GenreName == "")
            {
                return new GameStoreResponse("Genre name cannot be blank");
            }
            return new GameStoreResponse();
        }
    }
}

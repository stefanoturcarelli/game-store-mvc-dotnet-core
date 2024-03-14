using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities.Entities;

namespace BLL
{
    public class GenreService
    {
        GenreRepository genreRepository = new GenreRepository();
        public List<Genre> GetAllGenresService()
        {
            return genreRepository.GetAllGenresRepository();
        }

    }
}

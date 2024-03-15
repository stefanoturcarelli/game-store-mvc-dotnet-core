using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.DTO.GameFilter
{
    public class GameFilter : IGameFilter
    {
        //If these are manipulated to invalid ids then the filter will return nothing, which is expected behaviour.
        public int? GenreId { get; set; }
        public int? PublisherId { get; set; }
        public int? PlatformId { get; set; }
        public string? SearchString { get; set; }
        public GameFilter() { }

        public IEnumerable<Game> Filter(IEnumerable<Game> games)
        {
            if (this.GenreId != null)
            {
                games = games.Where(x => x.GenreId == this.GenreId);
            }
            if (this.PublisherId != null)
            {
                games = games.Where(x => x.PublisherId == this.PublisherId);
            }
            if (this.PlatformId != null)
            {
                games = games.Where(x => x.PlatformId == this.PlatformId);
            }
            if (this.SearchString!=null)
            {
                games = games.Where(x => x.GameName.ToLower().Contains(SearchString.ToLower()));
            }
            return games;
        }
    }
}

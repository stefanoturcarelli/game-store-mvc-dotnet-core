using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.DTO.GameFilter
{
    //Interface for game filtering objects
    public interface IGameFilter
    {
        public IEnumerable<Game> Filter(IEnumerable<Game> games);
    }
}

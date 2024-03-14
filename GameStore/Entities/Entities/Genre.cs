using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [MaxLength(32)]
        public string GenreName { get; set; }
    }
}

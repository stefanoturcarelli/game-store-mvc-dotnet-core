using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        [MaxLength(64)]
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        [Column(TypeName = "decimal(14,2)")]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}

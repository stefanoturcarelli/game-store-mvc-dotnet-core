using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        [MaxLength(64)]
        public string PublisherName { get; set; }
        [MaxLength(320)]
        public string PublisherEmail { get; set; }
        public string PublisherDescription { get; set; }
    }
}

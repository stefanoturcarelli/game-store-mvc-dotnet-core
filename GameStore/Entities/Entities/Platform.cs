using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        [MaxLength(64)]
        public string PlatformName { get; set; }
    }
}

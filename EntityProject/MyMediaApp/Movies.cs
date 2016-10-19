using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MyMediaApp
{
    class Movies : DbSet
    {
        [Key]
        public string movieID { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
    }
}

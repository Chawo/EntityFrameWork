using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MyMediaApp
{
    class Papers :DbSet
    {
        [Key]
        public int paperID { get; set; }
        public string author { get; set; }
        public string title { get; set; }
    }
}

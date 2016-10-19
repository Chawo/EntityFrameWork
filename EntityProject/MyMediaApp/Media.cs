using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyMediaApp
{
    class Media : DbContext
    {
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Papers> Papers { get; set; }
    }
}

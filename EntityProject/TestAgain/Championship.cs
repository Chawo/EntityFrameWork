using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace TestAgain
{
    class Championship :DbContext
    {
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Game> Games { get; set; }

    }
}

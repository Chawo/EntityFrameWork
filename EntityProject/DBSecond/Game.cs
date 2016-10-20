using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DBSecond
{
    class Game : DbSet
    {
        [Key]
        public int gameID { get; set; }
        public string gameTitle { get; set; }
        public string gameConsole { get; set; }
        public string company { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestAgain
{
    class Game:DbSet
    {
        [Key]
        public int GameID { get; set; }
        public string GameTitle { get; set; }
        public string GameConsole { get; set; }
    }
}

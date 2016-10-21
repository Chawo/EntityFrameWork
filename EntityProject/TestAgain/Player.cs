using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TestAgain
{
    class Player : DbSet
    {
        [Key]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }

        public DateTime PlayerEnrollmentDate { get; set; }
        
    }
}

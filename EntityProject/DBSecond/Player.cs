using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DBSecond
{
    class Player : DbSet
    {
        [Key]
        public int playerID { get; set; }
        public DateTime PlayerEnrollmentDate { get; set; }
        public string username { get; set; }
        public string psw { get; set; }
        public int level { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Championship())
            {
                Player player = new Player()
                {
                    username = "Awesome Gamer",
                    PlayerEnrollmentDate = DateTime.Now
                };
               
                ctx.Players.Add(player);
                ctx.SaveChanges();
            }
        }
    }
}

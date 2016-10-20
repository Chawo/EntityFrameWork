using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyMediaApp
{
    class CRUD 
    {
        public void CreateBook (Books book)
        {
            using (var ctx = new Media())
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
            }
                
        }

    }
}

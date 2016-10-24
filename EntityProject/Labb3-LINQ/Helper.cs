using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_LINQ
{
    static class Helper
    {
        public static float ConvertStringToFloat (string myWord)
        {
            float number = 0.0F;
            number = float.Parse(myWord);
            return number;
            
        }
    }
}

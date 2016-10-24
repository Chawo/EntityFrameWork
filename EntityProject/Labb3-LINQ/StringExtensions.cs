using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_LINQ
{
    static class StringExtensions
    {
        public static float ExtensionsConvertFloatToString (this string stringToFloat)
        {
            return float.Parse(stringToFloat);
        }
    }
}

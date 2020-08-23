using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedType
{
    public static class Core
    {

        public static bool IsDefault<T>(this T value) where T : class
        {
            return default == value;
        }

  
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedString
{
    public static class Core
    {
        public static bool IsEmpty(this string value)
        {
            return value == string.Empty;
        }

        public static bool IsWhiteSpace(this string value)
        {
            return value?.Trim() == string.Empty;
        }
    }
}

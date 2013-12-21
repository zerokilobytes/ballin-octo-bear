using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arisoph.Common
{
    public static class StringExtention
    {
        static public string Ellipsis(this String text, int length)
        {
            if (text.Length <= length) return text;
            int pos = text.IndexOf(" ", length);
            if (pos >= 0)
            {
                return text.Substring(0, pos) + "...";
            }
            else
            {
                return text.Substring(0, length) + "...";
            }
        }
    }
}

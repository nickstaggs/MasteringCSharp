using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public static class Extensions
    {

        public static string Reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public static bool IsGreaterThan5(this string input)
        {
            return input.Length > 5;
        }
    }
}

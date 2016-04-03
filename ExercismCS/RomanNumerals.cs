using System.Collections.Generic;

namespace ExercismCS
{
    public static class RomanNumerals
    {
        private static Dictionary<string, int> RomanNumeralMap = new Dictionary<string, int>( )
            {
                { "M", 1000 }, { "CM", 900 }, { "D", 500 }, {  "CD", 400 }, { "C", 100 }, { "XC", 90 },
                {  "L", 50 }, { "XL", 40 }, { "X", 10 }, { "IX", 9 }, { "V", 5 }, { "IV", 4 }, { "I", 1 }
            };

        public static string ToRoman( this int number )
        {
            var result = "";

            if ( number > 0 )
            {
                foreach ( var mapping in RomanNumeralMap )
                {
                    while ( number >= mapping.Value )
                    {
                        result += mapping.Key;
                        number -= mapping.Value;
                    }
                }
            }

            return result;
        }

    }
}

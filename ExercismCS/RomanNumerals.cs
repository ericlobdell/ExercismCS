using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class RomanNumerals
    {
        public static string ToRoman( this int number )
        {

            return ConvertNumber( number );
        }

        private static string ConvertNumber( int number )
        {
            var RomanNumeralMap = new Dictionary<string, int>( )
            {
                { "M", 1000 }, { "CM", 900 }, { "D", 500 }, {  "CD", 400 }, { "C", 100 }, { "XC", 90 },
                {  "L", 50 }, { "XL", 40 }, { "X", 10 }, { "IX", 9 }, { "V", 5 } { "IV", 4 }, { "I", 1 }
            };

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class Binary
    {
        public static int ToDecimal(string binary)
        {
            var result = 0;
            var len = binary.Length;
            var rightMostIndex = len - 1;

            if ( IsValid(binary) )
                for ( int i = 0; i < len; i++ )
                    result += int.Parse( binary [ rightMostIndex - i ].ToString( ) ) * ( int ) Math.Pow( 2, i );

            return result;
        }

        private static bool IsValid( string binary )
        {
            return new Regex( @"^[1|0]+$" ).IsMatch( binary );
        }
    }
}

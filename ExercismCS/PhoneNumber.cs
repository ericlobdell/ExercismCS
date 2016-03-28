using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercismCS
{
    public class PhoneNumber
    {
        public string Number { get; }
        public string AreaCode
        {
            get
            {
                return Number.Substring( 0, 3 );
            }
        }

        public PhoneNumber( string digits )
        {
            var cleaned = CleanDigits( digits );

            Number = "0000000000";

            if ( cleaned.Length == 10 )
                Number = cleaned;
            else if ( cleaned.Length == 11 && cleaned.StartsWith( "1" ) )
                Number = cleaned.Substring( 1 );
        }

        public override string ToString( )
        {
            return $"({AreaCode}) {Number.Substring( 3, 3 )}-{Number.Substring( 6, 4 )}";
        }

        private string CleanDigits( string input )
        {
            return new Regex( @"[\s().-]" )
                .Replace( input, "" );
        }
    }
}

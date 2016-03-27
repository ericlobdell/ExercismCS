using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class Bob
    {
        public static string Hey(string phrase)
        {
            var sut = phrase.Trim( );

            if ( IsEmpty( sut ) )
                return "Fine. Be that way!";

            if ( IsQuestion( sut ) )
                return "Sure.";

            if ( IsExclaimation( sut ) )
                return "Whoa, chill out!";

            return "Whatever.";
        }

        private static bool IsEmpty(string s)
        {
            return string.IsNullOrWhiteSpace( s );
        }

        public static bool IsExclaimation( string s)
        {
            return IsAllCaps( s ) && !IsAllNumbers(s);
        }  

        private static bool IsQuestion(string s)
        {
            return s.EndsWith( "?" ) && !IsExclaimation( s );    
        }

        private static bool IsAllCaps(string s)
        {
            return s.ToUpper( ) == s;
        } 

        private static bool IsAllNumbers(string s)
        {
            var rgx = new Regex( @"[\s,?!]" );
            var stripped = rgx.Replace(s, "");
            int result;

            return int.TryParse( stripped, out result );

        }

        
    }
}

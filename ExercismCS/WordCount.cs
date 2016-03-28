using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class Phrase
    {
        public static Dictionary<string, int> WordCount(string phrase)
        {
            var counts = new Dictionary<string, int>( );
            var words = CleanAndSplit( phrase );

            foreach ( var word in words )
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if ( counts.ContainsKey( word ) )
                        counts [ word ] = counts [ word ] + 1;
                    else
                        counts.Add( word, 1 );
                }
            }

            return counts;
        }

        private static IEnumerable<string> CleanAndSplit( string phrase)
        {
            
            return phrase
                .Trim( )
                .Replace(',', ' ')
                .Split( ' ' )
                .Select( word =>
                {
                    var normalized = TrimQuotes( word ).ToLower();
                    return new Regex( @"[,:!&@$%^&.]" )
                        .Replace( normalized, "" );
                })
                .Where( word => word != string.Empty );
        }

        private static string TrimQuotes(string word)
        {
            var nonWords = new List<string> { "", "'", "''" };

            if ( nonWords.Contains( word ) )
                return string.Empty;

            if ( word.StartsWith( "'" ) )
                word = word.Substring( 1 );

            if ( word.EndsWith( "'" ) )
                word = word.Substring( 0, word.Length - 1 );

            return word;
        }
    }
}

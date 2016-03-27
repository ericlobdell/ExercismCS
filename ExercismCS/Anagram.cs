using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercismCS
{
    public class Anagram
    {
        private string _control;
        private string _original;

        public Anagram( string original )
        {
            _original = original;
            _control = Normalize( original );
        }

        public IEnumerable<string> Match( IEnumerable<string> words )
        {
            return words
                .Where( w => Normalize( w ) == _control
                          && w.ToLower( ) != _original.ToLower( ) );
        }

        private string Normalize( string s )
        {
            return string.Concat(
                    s
                    .ToLower( )
                    .OrderBy( c => c )
                );
        }
    }
}

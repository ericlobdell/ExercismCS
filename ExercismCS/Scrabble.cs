﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExercismCS
{
    public class Scrabble
    {
        private static Dictionary<char, int> _scoreTable = new Dictionary<char, int>( )
        {
            { 'A', 1 }, { 'B', 3 }, { 'C', 3 }, { 'D', 2 }, { 'E', 1 }, { 'F', 4 }, { 'G', 2 },
            { 'H', 4 }, { 'I', 1 }, { 'J', 8 }, { 'K', 5 }, { 'L', 1 }, { 'M', 3 }, { 'N', 1 },
            { 'O', 1 }, { 'P', 3 }, { 'Q', 10 }, { 'R', 1 }, { 'S', 1 }, { 'T', 1 }, { 'U', 1 },
            { 'V', 4 }, { 'W', 4 }, { 'X', 8 }, { 'Y', 4 }, { 'Z', 10 }
        };
        public static int Score( string word )
        {
            return GetLetters( word )
                .Sum( GetLetterValue );
        }

        private static int GetLetterValue(char letter)
        {
            return _scoreTable[ letter ];
        }

        private static char [] GetLetters( string word )
        {

            if ( string.IsNullOrEmpty( word ) )
                return Array.Empty<char>();

            return new Regex( @"\s" )
                .Replace( word.ToUpper( ), "" )
                .ToCharArray( );
        }
    }
}

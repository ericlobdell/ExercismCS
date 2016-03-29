using System.Collections.Generic;
using System.Linq;

namespace ExercismCS
{
    public class SumOfMultiples
    {
        private static List<int> multiples;

        public static int To( int [] testMultiples, int num )
        {
            multiples = new List<int>( );

            foreach ( var test in testMultiples )
                for ( var i = 0; i < num; i++ )
                    if ( IsMultipleOf( i, test ) )
                        multiples.Add( i );

            return multiples.Distinct().Sum( );
        }

        private static bool IsMultipleOf( int num, int test )
        {
            return num % test == 0;
        }
    }
}

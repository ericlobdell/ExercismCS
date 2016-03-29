using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public class SumOfMultiples
    {
        private static List<int> multiples;

        public static int To( int[] testMultiples, int num)
        {
            multiples = new List<int>( );

            foreach ( var test in testMultiples )
                for ( int i = 0; i < num; i++ )
                    if ( IsMultipleOf( i, test ) && !multiples.Contains(i) )
                        multiples.Add( i );
               
            return multiples.Sum( );
        }

        private static bool IsMultipleOf( int num, int test)
        {
            return num % test == 0;
        }
    }
}

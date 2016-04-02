using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class Triangle
    {

        public static TriangleKind Kind( decimal a, decimal b, decimal c )
        {
            return EvaluateTriangle( a, b, c );
        }

        private static TriangleKind EvaluateTriangle( decimal a, decimal b, decimal c )
        {
            if ( !IsValidTriangle( a, b, c ) )
                throw new TriangleException( );

            var sides = new List<decimal> { a, b, c };
            var distinctSideLengths = sides.Distinct( ).Count( );

            if ( distinctSideLengths == 3 )
                return TriangleKind.Scalene;
            else if ( distinctSideLengths == 2 )
                return TriangleKind.Isosceles;
            else
                return TriangleKind.Equilateral;

        }

        private static bool IsValidTriangle( decimal a, decimal b, decimal c )
        {
            return ( a + b + c ) > 0 &&
                    ( a + b > c && a + c > b && b + c > a );
        }
    }

    public enum TriangleKind
    {
        Equilateral,
        Isosceles,
        Scalene
    }

    public class TriangleException : Exception
    {

    }
}


/*
on every year that is evenly divisible by 4
  except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400

*/
namespace ExercismCS
{
    public static class Year
    {
        public static bool IsLeap( int year )
        {
            if ( year.IsDivisibleBy( 4 ) )
            {
                if ( year.IsDivisibleBy( 100 ) )
                    return year.IsDivisibleBy( 400 );
                else
                    return true;
            }

            return false;

        }

        private static bool IsDivisibleBy( this int num, int test )
        {
            return num % test == 0;
        }
    }
}


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
            if ( IsDivisibleBy( year, 4 ) )
            {
                if ( IsDivisibleBy( year, 100 ) )
                    return IsDivisibleBy( year, 400 );
                else
                    return true;
            }

            return false;

        }

        private static bool IsDivisibleBy( int num, int test )
        {
            return num % test == 0;
        }
    }
}

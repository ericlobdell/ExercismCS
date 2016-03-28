namespace ExercismCS
{
    public static class Hamming
    {
        public static int Compute( string strand1, string strand2 )
        {
            var distance = 0;
            for ( int i = 0; i < strand1.Length; i++ )
            {
                if ( strand1 [ i ] != strand2 [ i ] )
                    distance++;
            }

            return distance;
        }
    }
}

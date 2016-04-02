using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public class SpaceAge
    {
        private long _earthYearInSeconds = 31557600;
        public long Seconds { get; set; }
        public SpaceAge( long ageInSeconds )
        {
            Seconds = ageInSeconds;
        }

        public double OnEarth()
        {
            return ComputeSpaceAge(1);
        }

        public double OnMars( )
        {
            return ComputeSpaceAge( 1.8808158 );
        }

        public double OnVenus( )
        {
            return ComputeSpaceAge( 0.61519726 );
        }

        public double OnMercury( )
        {
            return ComputeSpaceAge( 0.2408467 );
        }

        public double OnJupiter( )
        {
            return ComputeSpaceAge( 11.862615 );
        }

        public double OnSaturn( )
        {
            return ComputeSpaceAge( 29.447498 );
        }

        public double OnUranus( )
        {
            return ComputeSpaceAge( 84.016846 );
        }

        public double OnNeptune( )
        {
            return ComputeSpaceAge( 164.79132 );
        }

        private double ComputeSpaceAge( double multiplier )
        {
            return Seconds / ( _earthYearInSeconds * multiplier );
        }
    }
}

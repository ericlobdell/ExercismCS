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
            return 0.0;
        }

        public double OnMars( )
        {
            return 0.0;
        }

        public double OnVenus( )
        {
            return 0.0;
        }

        public double OnMercury( )
        {
            return 0.0;
        }

        public double OnJupiter( )
        {
            return 0.0;
        }

        public double OnSaturn( )
        {
            return 0.0;
        }

        public double OnUranus( )
        {
            return 0.0;
        }

        public double OnNeptune( )
        {
            return 0.0;
        }
    }
}

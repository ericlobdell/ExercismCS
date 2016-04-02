using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class Gigasecond
    {
        public static DateTime Date( DateTime birthDate )
        {
            return birthDate.AddSeconds( Math.Pow( 10.0, 9.0 ) );
        }
    }
}

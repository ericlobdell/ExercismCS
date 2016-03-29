using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public class Meetup
    {
        private List<DateTime> _calendar;
        private int [] _daysInMonth = new int []
            { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Meetup( int month, int year )
        {
            var daysInMonth = _daysInMonth[ month - 1 ];

            if ( Year.IsLeap( year ) && month == 2 )
                daysInMonth++;

            _calendar = new List<DateTime>( );

            for ( int day = 1; day <= daysInMonth; day++ )
                _calendar.Add( new DateTime( year, month, day ) );

        }

        public DateTime Day( DayOfWeek day, Schedule schedule )
        {
            DateTime meetupDate = DateTime.MinValue;
            var potentialDays = _calendar
                .Where( d => d.DayOfWeek == day )
                .ToArray( );

            if ( schedule == Schedule.First )
                meetupDate = potentialDays[ 0 ];

            else if ( schedule == Schedule.Second )
                meetupDate = potentialDays[ 1 ];

            else if ( schedule == Schedule.Third )
                meetupDate = potentialDays[ 2 ];

            else if ( schedule == Schedule.Fourth )
                meetupDate = potentialDays[ 3 ];

            else if ( schedule == Schedule.Last )
                meetupDate = potentialDays.Last( );

            else if ( schedule == Schedule.Teenth )
                meetupDate = potentialDays
                    .Where( d => d.Day >= 13 && d.Day <= 19 )
                    .First( );

            return meetupDate;
        }

    }

    public enum Schedule
    {
        First, Second, Third, Fourth, Teenth, Last
    }
}

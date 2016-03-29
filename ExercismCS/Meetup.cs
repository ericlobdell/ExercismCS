using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercismCS
{
    public class Meetup
    {
        private List<DateTime> _monthCalendar;
        private int [] _daysInMonth = new int []
            { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Meetup( int month, int year )
        {
            var daysInMonth = _daysInMonth[ month - 1 ];

            if ( Year.IsLeap( year ) && month == 2 )
                daysInMonth++;

            _monthCalendar = new List<DateTime>( );

            for ( int day = 1; day <= daysInMonth; day++ )
                _monthCalendar.Add( new DateTime( year, month, day ) );

        }

        public DateTime Day( DayOfWeek day, Schedule schedule )
        {
            DateTime meetupDate = DateTime.MinValue;
            var potentialDays = _monthCalendar
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class RomanNumerals
    {
        public static string ToRoman( this int number )
        {

            return ConvertNumber( number );
        }

        private static string ConvertNumber( int number )
        {
            var result = "";

            if (number > 0)
            {
                while (number >= 1000)
                {
                    result += "M";
                    number -= 1000;
                }

                if ( number >= 900 )
                {
                    result += "CM";
                    number -= 900;
                }

                if ( number >= 500 )
                {
                    result += "D";
                    number -= 500;
                }

                if ( number >= 400 )
                {
                    result += "CD";
                    number -= 400;
                }

                while ( number >= 100 )
                {
                    result += "C";
                    number -= 100;
                }

                if ( number >= 90 )
                {
                    result += "XC";
                    number -= 90;
                }

                if (number >= 50)
                {
                    result += "L";
                    number -= 50;
                }

                if ( number >= 40 )
                {
                    result += "XL";
                    number -= 40;
                }

                while ( number >= 10 )
                {
                    result += "X";
                    number -= 10;
                }

                if ( number == 9 )
                {
                    result += "IX";
                    number = 0;
                }

                if ( number >= 5 )
                {
                    result += "V";
                    number -= 5;
                }

                if ( number == 4 )
                {
                    result += "IV";
                    number = 0;
                }

                while ( number > 0 )
                {
                    result += "I";
                    number -= 1;
                }

            }

            return result;
        }

    }
}

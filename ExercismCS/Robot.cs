using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public class Robot
    {
        private char [] letters = new char [] 
            { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public string Name { get; set; }

        public Robot( )
        {
            SetName( DateTime.Now.Millisecond );
        }

        public void Reset()
        {
            SetName( 500 );
        }

        private void SetName( int seed )
        {
            Name = $"{GetRandomLetterSeq( seed )}{GetRandomNumber( seed )}";
        }

        private int GetRandomNumber( int seed )
        {
            var rand = new Random( seed );
            return rand.Next( 999 );
        }

        private string GetRandomLetterSeq( int seed )
        {
            var rand1 = new Random( seed );
            var rand2 = new Random( seed );
            var max = letters.Length - 1;

            var letter1Index = rand1.Next( max );
            var letter2Index = rand2.Next( max );

            return $"{letters [ letter1Index ]}{letters [ letter2Index ]}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public class School
    {
        public Dictionary<int, List<string>> Roster { get; set; }

        public School( )
        {
            Roster = new Dictionary<int, List<string>>( );
        }

        public void Add( string name, int grade )
        {
            if ( Roster.ContainsKey( grade ) )
            {
                Roster [ grade ].Add( name );
                Roster [ grade ].Sort( );
            }
            else
                Roster.Add( grade, new List<string> { name } );
        }

        public List<string> Grade( int grade )
        {
            if ( Roster.ContainsKey( grade ) )
                return Roster [ grade ];
            else
                return new List<string>( );
        }
    }
}

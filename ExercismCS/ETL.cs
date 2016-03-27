using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public static class ETL
    {
        public static Dictionary<string, int> Transform( Dictionary<int, IList<string>> data )
        {
            var result = new Dictionary<string, int>( );

            foreach ( var record in data )
            {
                foreach ( var letter in record.Value )
                {
                    result.Add( letter.ToLower(), record.Key );
                }
            }

            return result;
        }
    }
}
 
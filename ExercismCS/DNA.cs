using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCS
{
    public class DNA
    {
        public Dictionary<char, int> NucleotideCounts { get; private set; }

        public DNA( string strand )
        {
            NucleotideCounts = new Dictionary<char, int>
                { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };

            foreach ( var nucleotide in strand )
                NucleotideCounts [ nucleotide ]++;
        }

        public int Count(char nucleotide )
        {
            if ( !NucleotideCounts.ContainsKey( nucleotide ) )
                throw new InvalidNucleotideException( );

            return NucleotideCounts[nucleotide];
        }
    }

    public class InvalidNucleotideException : Exception { }
}

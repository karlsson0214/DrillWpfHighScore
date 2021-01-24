using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DrillWpfHighScore
{
    class Result : IComparable<Result>
    {
        private int score;

        // konstruktor


        // property
        public int Score
        {
            get
            {
                return score;
            }
        }


        public int CompareTo([AllowNull] Result other)
        {
            if (other == null)
            {
                // this is first
                return -1;
            }
            else if (Score > other.Score)
            {
                // this is first
                return -1;
            }
            else
            {
                // other is first
                return 1;
            }                
        }
    }
}
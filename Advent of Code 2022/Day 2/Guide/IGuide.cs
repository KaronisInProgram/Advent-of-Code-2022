using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2.Guide
{
    internal interface IGuide
    {
        IEnumerable<(char enemy, char player)> Matches { get; }
        IEnumerable<int> MatchScores { get; }
        int Score { get; }
    }
}
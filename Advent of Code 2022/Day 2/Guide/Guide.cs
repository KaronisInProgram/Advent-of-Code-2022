using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2.Guide
{
    internal class Guide : IGuide
    {
        public Guide(IEnumerable<(char enemy, char player)> matches)
        {
            this.Matches = matches;
        }

        public IEnumerable<(char enemy, char player)> Matches { get; } = new List<(char enemy, char player)>();

        public int ScoreFromPart1 => Matches.Select(ScoreCalculation).Sum();
        public int ScoreFromPart2 => Matches.Select(SwitchPlayerMoves).Select(ScoreCalculation).Sum();

        private (char enemy, char player) SwitchPlayerMoves((char enemy, char player) element)
        {
            return element switch
            {
                // Player lose
                ('A', 'X') => ('A', 'Z'),
                ('B', 'X') => ('B', 'X'),
                ('C', 'X') => ('C', 'Y'),

                // Draw
                ('A', 'Y') => ('A', 'X'),
                ('B', 'Y') => ('B', 'Y'),
                ('C', 'Y') => ('C', 'Z'),

                // Player win
                ('A', 'Z') => ('A', 'Y'),
                ('B', 'Z') => ('B', 'Z'),
                ('C', 'Z') => ('C', 'X'),

                // Bad input
                _ => throw new NotImplementedException(),
            };
        }

        private int ScoreCalculation((char enemy, char player) element)
        {
            var shapeScore = element switch
            {
                (_, 'X') => 1,
                (_, 'Y') => 2,
                (_, 'Z') => 3,

                // Bad input
                _ => throw new NotImplementedException(),
            };

            var matchScore = element switch
            {
                // Draw
                ('A', 'X') => 3,
                ('B', 'Y') => 3,
                ('C', 'Z') => 3,

                // Player win
                ('A', 'Y') => 6,
                ('B', 'Z') => 6,
                ('C', 'X') => 6,

                // Player lose
                ('A', 'Z') => 0,
                ('B', 'X') => 0,
                ('C', 'Y') => 0,

                // Bad input
                _ => throw new NotImplementedException(),
            };

            return shapeScore + matchScore;
        }
    }
}
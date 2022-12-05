using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_2.Guide
{
    internal class GuideCreator
    {
        public static IGuide Create(string inputFile)
        {
            var matches = ReadRawData(inputFile).Select(line => (enemy: line[0], player: line[2]));

            return new Guide(matches);
        }

        private static IEnumerable<string> ReadRawData(string inputFile)
        {
            try
            {
                return File.ReadLines(inputFile);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The File at Path {inputFile} is not valid.", ex);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_3.Backpack
{
    internal class BackpackListCreator
    {
        public static IList<IBackpack> Create(string inputFile)
        {
            IList<IBackpack> result = new List<IBackpack>();

            foreach (var line in ReadRawData(inputFile))
            {
                result.Add(new Backpack(line));
            }

            return result;
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
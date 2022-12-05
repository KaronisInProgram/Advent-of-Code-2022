using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.Elf
{
    internal class CarrierListCreator
    {
        public static IList<ICarrier<int>> Create(string inputFile)
        {
            IList<ICarrier<int>> result = new List<ICarrier<int>>();

            ICarrier<int> elf = new Elf();
            foreach (var dataLine in ReadRawData(inputFile))
            {
                if (string.IsNullOrWhiteSpace(dataLine))
                {
                    result.Add(elf);
                    elf = new Elf();

                    continue;
                }

                if (int.TryParse(dataLine, out int calories))
                {
                    elf.Values.Add(calories);
                }
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
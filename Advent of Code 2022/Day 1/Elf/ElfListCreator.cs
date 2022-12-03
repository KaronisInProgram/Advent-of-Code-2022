using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.Elf
{
    using Food;

    internal class ElfListCreator
    {
        public IList<Elf> CreateList(string inputFile)
        {
            IList<Elf> result = new List<Elf>();

            Elf elf = new Elf();
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
                    elf.Add(new Food(calories));
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
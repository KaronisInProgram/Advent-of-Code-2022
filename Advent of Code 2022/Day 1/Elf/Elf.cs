using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.Elf
{
    internal class Elf : ICarrier<int>
    {
        public ICollection<int> Values { get; } = new List<int>();
    }
}
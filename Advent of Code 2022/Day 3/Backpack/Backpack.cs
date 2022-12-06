using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3.Backpack
{
    internal class Backpack : IBackpack
    {
        public Backpack(string items)
        {
            Items = items;

            var half = (items.Length / 2);

            var compartment1 = items[0..half];
            var compartment2 = items[half..items.Length];

            // Remove potential double values befor the analyse
            DuplicateInComponents = compartment1.Distinct().Single(compartment2.Contains);
        }

        public char DuplicateInComponents { get; }

        public string Items { get; }

        public static int CalculateItemPriority(char item)
        {
            var underlyingValue = Convert.ToInt32(item);
            return char.IsUpper(item) ? underlyingValue - 38 : underlyingValue - 96;
        }
    }
}
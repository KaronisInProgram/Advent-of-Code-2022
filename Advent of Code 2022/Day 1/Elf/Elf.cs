using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.Elf
{
    using Food;

    internal class Elf : ICarrier<IOwnsCalories>
    {
        private readonly ICollection<IOwnsCalories> ownedCalories = new List<IOwnsCalories>();

        public void Add(IOwnsCalories element) => ownedCalories.Add(element);

        public int OwnedValue() => ownedCalories.Sum(element => element.GetCalories());
    }
}
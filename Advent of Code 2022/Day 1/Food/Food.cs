using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.Food
{
    internal class Food : IOwnsCalories
    {
        private readonly int calories;

        public Food(int calories) => this.calories = calories;

        public int GetCalories() => calories;
    }
}
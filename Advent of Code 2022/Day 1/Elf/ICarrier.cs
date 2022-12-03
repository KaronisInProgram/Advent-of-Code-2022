using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.Elf
{
    internal interface ICarrier<in T>
    {
        void Add(T element);

        int OwnedValue();
    }
}
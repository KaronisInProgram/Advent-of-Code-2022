using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3.Backpack
{
    internal interface IBackpack
    {
        string Items { get; }

        char DuplicateInComponents { get; }
    }
}
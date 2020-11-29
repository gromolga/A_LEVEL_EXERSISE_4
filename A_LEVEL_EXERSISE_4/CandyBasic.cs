using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_4
{
    public abstract class CandyBasic
    {
        public int Weight { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public CandyBasic(int weight, string name, string brand)
        {
            Weight = weight;
            Name = name;
            Brand = brand;
        }

    }
}

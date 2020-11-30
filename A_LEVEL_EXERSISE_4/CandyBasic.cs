using System;
using System.Collections.Generic;
using System.Text;

namespace A_LEVEL_EXERSISE_4
{
    public abstract class CandyBasic : IComparable
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

        public int CompareTo(object obj)
        {
            CandyBasic item = obj as CandyBasic;
            if (item != null)
                return this.Weight.CompareTo(item.Weight);
            else
                throw new Exception("Can't be compared");
        }
    }
}

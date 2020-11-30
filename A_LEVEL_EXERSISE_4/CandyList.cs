using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A_LEVEL_EXERSISE_4
{
    public class CandyList
    {
        CandyBasic[] list = { };
        public void Add(CandyBasic candy)
        {
            CandyBasic[] newList = { candy };
            list = list.Concat(newList).ToArray();
        }

        public CandyBasic[] ToArray()
        {
            return list;
        }
    }
}

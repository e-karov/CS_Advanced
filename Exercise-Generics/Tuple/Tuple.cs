using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TItem1, TItem2>
    {
        public TItem1 Item1 { get; set; }

        public TItem2 Item2 { get; set; }

        public Tuple(TItem1 item1, TItem2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;

        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Series(int start=0)
    {
        private int _start= start;

        public int Next() => _start++;
    }
}

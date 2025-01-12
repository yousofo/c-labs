using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class CustomHashSet
    {
        HashSet<int> test = new();
        
    
        public void Add(int value) { }
        public void Clear() { }
        public bool Contains(int value) { return false; }
        public bool Remove(int value) { return false; }
            
    }
}

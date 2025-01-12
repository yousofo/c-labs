using day4.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Football
{
    internal class Player(int id, string name) : Identity(id, name)
    {

        public void Move()
        {
            Console.WriteLine(this + " moved");
        }



    }
}

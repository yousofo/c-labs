using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Football
{
    internal class Ball
    {
        private int _x = 0; private int _y;

        public Action OnBallMove;

        public void Move(int x = 0, int y = 0)
        {
            _x = x;
            _y = y;

            OnBallMove.Invoke();

        }

    }
}

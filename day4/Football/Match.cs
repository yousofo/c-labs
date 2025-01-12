using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Football
{
    internal class Match
    {
        public PlayersClass players = [];

        public Refree refree;

        public Ball ball = new();

        public Match()
        {
            players.match = this;
            ball.OnBallMove += refree.Move;

        }

        public class PlayersClass : List<Player>
        {
            public Match match;
            public new void Add(Player p)
            {
                base.Add(p);
                match.ball.OnBallMove += p.Move;
            }

            public new void Remove(Player p)
            {
                base.Remove(p);

                match.ball.OnBallMove -= p.Move;

                Console.WriteLine($"removed player ({p.Id}:{p.Name})");
            }
        }
    }
}

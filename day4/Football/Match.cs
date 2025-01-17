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

        public Ball Ball
        {
            get; set;
        }


        public Match()
        {
            Ball = new Ball();
            refree = new(1, "refree name");
            this.Ball.OnBallMove += refree.Move;
            players.match = this;
        }

        public class PlayersClass : List<Player>
        {
            public Match match;
            public new void AddRange(IEnumerable<Player> players)
            {
                foreach (var p in players)
                {
                    match.Ball.OnBallMove += p.Move;
                }
                base.AddRange(players);
            }
            public new void Remove(Player p)
            {
                base.Remove(p);

                match.Ball.OnBallMove -= p.Move;

                Console.WriteLine($"removed player ({p.Id}:{p.Name})");
            }


        }
    }
}

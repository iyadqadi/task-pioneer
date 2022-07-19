using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class knightMoves
    {
        public static List<Pair> Moves = new List<Pair>();
        static  knightMoves()
        {
            Moves.Add(new Pair(1, -2));
            Moves.Add(new Pair(1, 2));
            Moves.Add(new Pair(2, 1));
            Moves.Add(new Pair(2, -1));
            Moves.Add(new Pair(-1, 2));
            Moves.Add(new Pair(-1, -2));
            Moves.Add(new Pair(-2, 1));
            Moves.Add(new Pair(-2, -1));
        }

    }
}

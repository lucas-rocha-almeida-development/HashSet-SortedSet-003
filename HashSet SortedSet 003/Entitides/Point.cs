using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SortedSet_003.Entitides
{
    internal struct Point//tipo valor struct( tipo conteudo e não referencia)
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int x, int y) :this()
        {
            X = x;
            Y = y;
        }

    }
}

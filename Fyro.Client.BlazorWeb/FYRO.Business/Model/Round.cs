using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYRO.Business.Model
{
    public class Round
    {
        public Club Club { get; set; }

        public Hole StartingHole { get; set; }

        public List<Pairing> Pairings { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYRO.Business.Model
{
    public class HoleScore
    {
        public Pairing Pairing { get; set; }

        public Hole Hole { get; set; }

        public int Score { get; set; }
    }
}

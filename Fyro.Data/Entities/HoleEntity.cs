using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class HoleEntity
    {
        public Guid Id { get; set; }

        public GolfEntity Golf { get; set; }

        public int Number { get; set; }

        public int Par { get; set; }
    }
}

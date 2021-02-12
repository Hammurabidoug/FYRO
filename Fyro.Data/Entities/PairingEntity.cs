using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class PairingEntity
    {
        public Guid Id { get; set; }

        public int Order { get; set; }

        public GolfEntity Golf { get; set; }

        public List<DufferEntity> Duffers { get; }

        public List<HoleScoreEntity> Scores { get; }
    }
}

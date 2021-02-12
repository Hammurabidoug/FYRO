using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class PairingAwardEntity
    {
        public Guid Id { get; set; }

        public PairingEntity Pairing { get; set; }

        public CompetitionEntity CompetitionEntity { get; set; }
    }
}

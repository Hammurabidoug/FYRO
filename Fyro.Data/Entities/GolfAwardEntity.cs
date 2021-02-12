using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class GolfAwardEntity
    {
        public Guid Id { get; set; }

        public GolfEntity Golf { get; set; }

        public List<IndividualAwardEntity> IndividualAwards { get; }

        public PairingAwardEntity PairingAward { get; set; }
    }
}

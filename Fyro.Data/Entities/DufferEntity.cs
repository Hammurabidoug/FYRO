using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class DufferEntity : ContactEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<EventEntity> Events { get; set; }

        public List<PairingEntity> Pairings { get; set; }

        public List<IndividualAwardEntity> IndividualAwards { get; }

        public List<PairingAwardEntity> PairingAwards { get; }
    }
}

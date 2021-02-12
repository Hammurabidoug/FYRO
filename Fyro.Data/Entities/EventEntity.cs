using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class EventEntity : LocationEntity
    {
        public int Number { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public LodgingEntity Lodging { get; set; }

        public List<DufferEntity> Duffers { get; set; }

        public List<GolfEntity> Golfs { get; set; }

        public List<IndividualAwardEntity> IndividualAwards { get; }
    }
}

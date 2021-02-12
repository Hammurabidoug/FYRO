using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class EventLodgingEntity
    {
        public Guid Id { get; set; }
        public EventEntity Event { get; set; }

        public LodgingEntity Lodging { get; set; }

        public List<CondoEntity> Condos { get; set; }
    }
}

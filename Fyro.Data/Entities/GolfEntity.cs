using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class GolfEntity : ContactEntity
    {
        public Guid Id { get; set; }

        public CourseEntity Course { get; set; }

        public EventEntity Event { get; set; }

        public List<PairingEntity> Pairings { get; set; }

        public PairingEntity Winner { get; set; }
    }
}

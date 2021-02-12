using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class CondoEntity : LocationEntity
    {
        public LodgingEntity Lodging { get; set; }
        
        public List<DufferEntity> Duffers { get; }
    }
}

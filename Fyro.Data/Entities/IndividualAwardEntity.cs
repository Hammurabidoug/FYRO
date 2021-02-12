using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class IndividualAwardEntity
    {
        public Guid Id { get; set; }

        public DufferEntity Duffer { get; set; }

        public CompetitionEntity Competition { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class CompetitionEntity
    {
        public Guid Id { get; set; }

        public CompetitionScope Scope { get; set; }

        public CompetitionType Type { get; set; }
    }
}

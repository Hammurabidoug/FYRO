using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class DufferCondoEntity
    {
        public Guid Id { get; set; }

        public CondoEntity Condo { get; set; }
    }
}

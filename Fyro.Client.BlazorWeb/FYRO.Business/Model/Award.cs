using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYRO.Business.Model
{
    public class Award
    {
        public string Name { get; set; }

        public Duffer Duffer { get; set; }

        public Event Event { get; set; }
    }
}

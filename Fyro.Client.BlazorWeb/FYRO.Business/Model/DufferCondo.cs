using FYRO.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYRO.Business
{
    public class DufferCondo
    {
        public Condo Condo { get; set; }

        public Duffer Duffer { get; set; }

        public List<Duffer> Condomates { get; }
    }
}

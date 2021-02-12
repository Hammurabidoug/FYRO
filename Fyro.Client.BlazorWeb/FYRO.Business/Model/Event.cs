using System;
using System.Collections.Generic;

namespace FYRO.Business.Model
{
    public class Event
    {
        public DateTime BeginDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public List<Award> Awards { get; set; }
    }
}

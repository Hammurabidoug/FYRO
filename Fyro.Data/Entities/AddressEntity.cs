﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data.Entities
{
    public class AddressEntity
    {
        public Guid Id { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }
    }
}

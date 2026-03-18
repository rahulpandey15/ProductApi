using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain
{
    public class OrderDomain
    {
        public int Id { get; set; }

        public string OrderName { get; set; }

        public string OrderDescription { get; set; }
    }
}

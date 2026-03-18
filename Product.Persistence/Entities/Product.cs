using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Persistence.Entities
{
    internal class Products : AuditEntity
    {
        public int Id { get; set; }

        public string ProductName {  get; set; }

        public string ProductDescription { get; set; }

    }
}

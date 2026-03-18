

namespace Product.Persistence.Entities
{
    internal class Order : AuditEntity
    {
        public int Id {  get; set; }

        public string OrderName { get; set; } = default!;

        public string OrderDescription { get; set; } = default!;
    }
}

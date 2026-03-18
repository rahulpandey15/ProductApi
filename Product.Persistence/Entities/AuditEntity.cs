

namespace Product.Persistence.Entities
{
    public class AuditEntity
    {
        public string CreatedBy { get; set; } = default!;
        public DateTime CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}

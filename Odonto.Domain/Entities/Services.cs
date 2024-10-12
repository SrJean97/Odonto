using Odonto.Domain.Entities.Base;

namespace Odonto.Domain.Entities
{
    public class Services : BaseEntity<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public BaseAuditInfo AuditInfo { get; set; } = new BaseAuditInfo();
    }
}

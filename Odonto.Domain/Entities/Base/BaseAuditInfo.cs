namespace Odonto.Domain.Entities.Base
{
    public class BaseAuditInfo
    {
        public int UserCreate { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UserUpdate { get; set; }
        public int? UserDelete { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}

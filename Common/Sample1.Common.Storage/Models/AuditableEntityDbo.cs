namespace Sample1.Common.Storage.Models
{
    public class AuditableEntityDbo
    {
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }

        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }

        public Guid CorrelationId { get; set; }
    }
}

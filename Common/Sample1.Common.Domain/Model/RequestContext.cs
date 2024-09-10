namespace Sample1.Common.Domain.Model
{
    [Serializable]
    public class RequestContext(int tenantId, string tenantName, Guid userId, string userName, string dbConnectionString, int weightingMethod, int userType)
    {
        public Guid CorrelationId { get; private set; } = Guid.NewGuid();
        public Guid UserId { get; private set; } = userId;
        public string UserName { get; private set; } = userName;
        public int TenantId { get; private set; } = tenantId;
        public int UserType { get; private set; } = userType;
        public string TenantName { get; private set; } = tenantName;
        public string DatabaseConnectionString { get; private set; } = dbConnectionString;
        public int WeightingMethod { get; private set; } = weightingMethod;
    }
}

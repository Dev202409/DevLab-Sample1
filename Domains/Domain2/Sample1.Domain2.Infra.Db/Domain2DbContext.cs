using Sample1.Domain2.Infra.Db.Maps;
using Sample1.Domain2.Storage;
using Sample1.Common.Domain.Model;
using Sample1.Common.Domain.Outgoings;
using Sample1.Common.Storage.Interfaces;
using Sample1.Common.Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace Sample1.Administration.Infra.Db
{
    public class Domain2DbContext : DbContext, IDomain2DbContext
    {
        private readonly RequestContext _requestContext;

        public Domain2DbContext() { }
        public Domain2DbContext(DbContextOptions<Domain2DbContext> options, IRequestContextService requestContextService)
            : base(options)
        {
            _requestContext = requestContextService.GetCurrentRequestContext();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=Administration;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Entity1Map());
            modelBuilder.ApplyConfiguration(new Entity2Map());
        }

        DbSet<TEntity> ISample1DbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        public Task<int> SaveChangesAsync()
        {
            var date = DateTime.UtcNow;

            foreach (var entry in ChangeTracker.Entries<AuditableEntityDbo>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _requestContext.UserId;
                        entry.Entity.Created = date;
                        entry.Entity.CorrelationId = _requestContext.CorrelationId;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _requestContext.UserId;
                        entry.Entity.LastModified = date;
                        entry.Entity.CorrelationId = _requestContext.CorrelationId;
                        break;
                }
            }

            return base.SaveChangesAsync();
        }

        public void ExecuteStoredProcedure(string name, int investmentId)
        {
            throw new NotImplementedException();
        }
    }
}

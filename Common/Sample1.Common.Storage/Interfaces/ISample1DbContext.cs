using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Sample1.Common.Storage.Interfaces;

public interface ISample1DbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class, ISample1DbObject;
    Task<int> SaveChangesAsync();
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;
}
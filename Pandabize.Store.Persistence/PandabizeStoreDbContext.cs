using Microsoft.EntityFrameworkCore;
using Pandabize.Store.Domain.Common;
using Pandabize.Store.Domain.Entities;

namespace Pandabize.Store.Persistence
{
    public class PandabizeStoreDbContext : DbContext
    {
        public PandabizeStoreDbContext(DbContextOptions<PandabizeStoreDbContext> options)
           : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PandabizeStoreDbContext).Assembly);

            //seed data, added through migrations
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

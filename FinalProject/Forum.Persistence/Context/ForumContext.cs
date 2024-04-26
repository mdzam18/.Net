using Forum.Domain.Comments;
using Forum.Domain.Topics;
using Forum.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Forum.Persistence.Context
{
    public class ForumContext : DbContext
    {

        public ForumContext(DbContextOptions<ForumContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (Exception)
            {
                var entities = ChangeTracker
                    .Entries()
                    .Where(e => e.Entity != null &&
                    (e.State == EntityState.Modified ||
                    e.State == EntityState.Added ||
                    e.State == EntityState.Deleted))
                    .ToList();


                foreach (var entity in entities)
                {
                    entity.State = entity.State switch
                    {
                        EntityState.Added => EntityState.Modified,
                        _ => EntityState.Unchanged,
                    };
                }
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ForumContext).Assembly);
        }

    }
}
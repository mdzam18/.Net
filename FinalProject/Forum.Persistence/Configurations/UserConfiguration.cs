using Forum.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Gender).IsRequired();

            builder.HasIndex(x => x.Username).IsUnique();

            builder.Property(x => x.Username).IsUnicode(false).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Password).IsUnicode(false).IsRequired().HasMaxLength(50);

            builder.Property(x => x.IsBanned).IsRequired();

            builder.Property(x => x.BanDate).HasColumnType("datetime").IsRequired(false);

            builder.Property(x => x.IsAdmin).IsRequired();

            builder.HasMany(x => x.Topics).WithOne(t => t.User).HasForeignKey(t => t.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Comments).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Application.Users;

namespace ToDo.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Username).IsUnique();

            builder.Property(x => x.Username).IsUnicode(false).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Password).IsUnicode(false).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Username).IsRequired().HasMaxLength(50);

        }

    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Forum.Domain.Topics;

namespace Forum.Persistence.Configurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired();

            builder.Property(x => x.Content).IsRequired();

            builder.HasMany(x => x.Comments).WithOne(x => x.Topic).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User).WithMany(x => x.Topics).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

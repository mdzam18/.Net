using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Forum.Domain.Comments;

namespace Forum.Persistence.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Content).IsRequired();

            //   builder.HasOne(x => x.User).WithMany(u => u.Comments).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

            //   builder.HasOne(x => x.Topic).WithMany(t => t.Comments).HasForeignKey(x => x.TopicId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Topic)
              .WithMany(t => t.Comments)
              .HasForeignKey(x => x.TopicId)
              .OnDelete(DeleteBehavior.Cascade); // Ensure cascade delete for Topic

            // Configure relationship with User
            builder.HasOne(x => x.User)
                   .WithMany(u => u.Comments)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

        }

    }
}

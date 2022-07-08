using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkersList.DataAccessLayer.Entities;

namespace WorkersList.DataAccessLayer.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> entityTypeBuilder)
        {
            /*
                Fields
            */
            entityTypeBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            entityTypeBuilder.Property(x => x.Text)
                .IsRequired()
                .HasMaxLength(100);//move to restriction file

            entityTypeBuilder.Property(x => x.Liked)
                .IsRequired();

            entityTypeBuilder.Property(x => x.Disliked)
                .IsRequired();

            entityTypeBuilder.Property(x => x.LastModifyInfoDate)
                .IsRequired()
                .HasDefaultValueSql("getdate()");//move to restriction file
            /*
                Connections
            */
            entityTypeBuilder
                .HasOne(x => x.ParentComment)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.ParentCommentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

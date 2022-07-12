using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkersList.DataAccessLayer.Entities;

namespace WorkersList.DataAccessLayer.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> entityTypeBuilder)
        {
            /*
                Fields
            */
            entityTypeBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            entityTypeBuilder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(64)
                .HasDefaultValue("Title");//move to restriction file

            entityTypeBuilder.Property(x => x.Text)
                .IsRequired()
                .HasMaxLength(64)
                .HasDefaultValue("Text");//move to restriction file

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
                .HasMany(x => x.Comments)
                .WithOne(x => x.Review)
                .HasForeignKey(x => x.ReviewId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}

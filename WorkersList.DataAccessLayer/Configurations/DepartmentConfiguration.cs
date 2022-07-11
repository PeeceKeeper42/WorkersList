using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkersList.DataAccessLayer.Entities;

namespace WorkersList.DataAccessLayer.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entityTypeBuilder)
        {
            /*
                Fields
            */
            entityTypeBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            entityTypeBuilder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            entityTypeBuilder.Property(x => x.HeadOfDepartmentId)
                .IsRequired();

            entityTypeBuilder.Property(x => x.ResponsibilityArea)
                .IsRequired();

            entityTypeBuilder.Property(x => x.LastModifyInfoDate)
                .IsRequired()
                .HasDefaultValueSql("getdate()");//move to restriction file
            /*
                Connections
            */
            entityTypeBuilder
                .HasMany(x => x.Reviews)
                .WithOne(x => x.Department)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}

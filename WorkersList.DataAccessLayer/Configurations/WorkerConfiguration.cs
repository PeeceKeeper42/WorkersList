using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkersList.DataAccessLayer.Entities;

namespace WorkersList.DataAccessLayer.Configurations
{
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> entityTypeBuilder)
        {
            /*
                Fields
            */
            entityTypeBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            entityTypeBuilder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(64)
                .HasDefaultValue("UserName");//move to restriction file

            entityTypeBuilder.Property(x => x.Surname)
                .IsRequired()
                .HasMaxLength(64)
                .HasDefaultValue("UserSurname");//move to restriction file

            entityTypeBuilder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(64);//move to restriction file
            entityTypeBuilder.HasIndex(x => x.Email)
                .IsUnique();

            entityTypeBuilder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(14);//move to restriction file

            entityTypeBuilder.Property(x => x.JobPosition)
                .IsRequired()
                .HasDefaultValue("Janitor");//move to restriction file

            entityTypeBuilder.Property(x => x.DateOfEmployment)
                .IsRequired()
                .HasDefaultValueSql("getdate()");//move to restriction file

            entityTypeBuilder.Property(x => x.LastModifyInfoDate)
                .IsRequired()
                .HasDefaultValueSql("getdate()");//move to restriction file
            /*
                Connections
            */
            entityTypeBuilder
                .HasOne(x => x.Department)
                .WithMany(x => x.Workers)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            entityTypeBuilder
                .HasMany(x => x.Reviews)
                .WithOne(x => x.Worker)
                .HasForeignKey(x => x.WorkerId)
                .OnDelete(DeleteBehavior.NoAction);

            entityTypeBuilder
                .HasMany(x => x.Comments)
                .WithOne(x => x.Worker)
                .HasForeignKey(x => x.WorkerId)
                .OnDelete(DeleteBehavior.NoAction);

            entityTypeBuilder
                .HasOne(x => x.WorkerPassword)
                .WithOne(x => x.Worker)
                .HasForeignKey<WorkerPassword>(x => x.WorkerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

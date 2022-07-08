using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkersList.DataAccessLayer.Entities;

namespace WorkersList.DataAccessLayer.Configurations
{
    public class WorkerPasswordConfiguration : IEntityTypeConfiguration<WorkerPassword>
    {
        public void Configure(EntityTypeBuilder<WorkerPassword> entityTypeBuilder)
        {
            /*
                Fields
            */
            entityTypeBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            entityTypeBuilder.Property(x => x.Salt)
                .IsRequired();

            entityTypeBuilder.Property(x => x.HashedPassword)
                .IsRequired();
            /*
                Connections
            */
        }
    }
}

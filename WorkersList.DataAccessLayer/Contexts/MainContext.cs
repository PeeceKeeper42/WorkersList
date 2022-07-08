using Microsoft.EntityFrameworkCore;
using WorkersList.DataAccessLayer.Entities;

namespace WorkersList.DataAccessLayer.Contexts
{
    public class MainContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerPassword> WorkerPasswords { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public MainContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-PJK3AQQHR2L;Initial Catalog = WorkersListDB;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

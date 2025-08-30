using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class Job_Board : DbContext
    {
        public Job_Board() : base() { }
        public Job_Board(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedCompanies();
            modelBuilder.SeedJobs();
            modelBuilder.SeedUsers();
        }





        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> Companies { get; set; }
    }

}

using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DataAccess
{
    public static class DbContextExtensions
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Alice HR", Email = "alice@company.com", PasswordHash = "hash1", Role = "HR", ProfileInfo = "HR Manager" },
                new User { Id = 2, Name = "Bob HR", Email = "bob@company.com", PasswordHash = "hash2", Role = "HR", ProfileInfo = "HR Specialist" },
                new User { Id = 3, Name = "Charlie Candidate", Email = "charlie@mail.com", PasswordHash = "hash3", Role = "Candidate", ProfileInfo = "Software Developer" },
                new User { Id = 4, Name = "Diana Candidate", Email = "diana@mail.com", PasswordHash = "hash4", Role = "Candidate", ProfileInfo = "QA Engineer" }
            );
        }

        public static void SeedCompanies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "TechCorp", Description = "Leading tech company", UserId = 1 },
                new Company { Id = 2, Name = "InnovateX", Description = "Startup for innovation", UserId = 2 }
            );
        }

        public static void SeedJobs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasData(
                new Job { Id = 1, Title = "Software Developer", Description = "Develop web apps", SalaryMin = 2000, SalaryMax = 4000, LSocation = "Kyiv", CompanyId = 1 },
                new Job { Id = 2, Title = "QA Engineer", Description = "Test software", SalaryMin = 1500, SalaryMax = 3000, LSocation = "Lviv", CompanyId = 1 },
                new Job { Id = 3, Title = "UI/UX Designer", Description = "Design interfaces", SalaryMin = 1800, SalaryMax = 3500, LSocation = "Remote", CompanyId = 2 }
            );
        }

    }
}

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
                new Job
                {
                    Id = 1,
                    Title = "Software Developer",
                    Description = "We are looking for a skilled Software Developer to join our dynamic team. You will be responsible for designing, coding, and maintaining web applications using modern technologies. The ideal candidate should have experience with C#, ASP.NET Core, and SQL databases, as well as a strong understanding of software design principles. You will work closely with product managers and designers to deliver high-quality features.",
                    SalaryMin = 2000,
                    SalaryMax = 4000,
                    LSocation = "Kyiv",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7vsQ87hL64dYCv53oQN7McuPipgKNw_5Z6A&s",
                    CompanyId = 1
                },
                new Job
                {
                    Id = 2,
                    Title = "QA Engineer",
                    Description = "Join our QA team to ensure the highest quality of our software solutions. As a QA Engineer, you will create and execute test cases, identify and document bugs, and collaborate with developers to resolve issues. Experience in manual testing is required, and knowledge of automated testing tools (Selenium, Postman) is a plus. Strong attention to detail and analytical skills are essential.",
                    SalaryMin = 1500,
                    SalaryMax = 3000,
                    LSocation = "Lviv",
                    ImageUrl = "https://inproject.org/wp-content/uploads/2023/02/divchuna-qa-1024x683.jpg",
                    CompanyId = 1
                },
                new Job
                {
                    Id = 3,
                    Title = "UI/UX Designer",
                    Description = "We are seeking a talented UI/UX Designer to create intuitive and visually appealing interfaces for our web and mobile applications. Your role will include user research, wireframing, prototyping, and collaborating with developers to implement your designs. The ideal candidate should have experience with Figma, Adobe XD, or similar tools, and a good understanding of user-centered design principles.",
                    SalaryMin = 1800,
                    SalaryMax = 3500,
                    LSocation = "Remote",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROSsJYCBw-B3S44zjkaA9otdPX8o5GO2QyEQ&s",
                    CompanyId = 2
                }
            );
        }


    }
}

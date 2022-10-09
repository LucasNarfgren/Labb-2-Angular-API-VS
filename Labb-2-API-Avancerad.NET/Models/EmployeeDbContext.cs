using Microsoft.EntityFrameworkCore;

namespace Labb_2_API_Avancerad.NET.Models
{
    public class EmployeeDbContext : DbContext
    {

        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, Name = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, Name = "HR" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, Name = "Economy" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, Name = "Service" });

            modelBuilder.Entity<Gender>().HasData(new Gender { GenderId = 1, Name = "Male"});
            modelBuilder.Entity<Gender>().HasData(new Gender { GenderId = 2, Name = "Female" });
            modelBuilder.Entity<Gender>().HasData(new Gender { GenderId = 3, Name = "Other" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Lucas",
                LastName = "Narfgren",
                Email = "narfgren@hotmail.com",
                Address = "Hertings Allé 5A",
                ZipCode = "311 45",
                City = "Falkenberg",
                Phone = "0707409223",
                Salary = 50000,
                DepartmentId = 1,
                GenderId = 1
            }); ;

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Johnny",
                LastName = "Karlsson",
                Email = "Karlsson@hotmail.com",
                Address = "Hertings Gatan 10A",
                ZipCode = "311 35",
                City = "Falkenberg",
                Phone = "0703678909",
                Salary = 35000,
                DepartmentId = 2,
                GenderId = 3
            }); ;
        }


    }
}

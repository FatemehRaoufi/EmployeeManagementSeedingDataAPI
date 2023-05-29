using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

//Adding   Microsoft.EntityFrameworkCore from Nuget to can inherit class from  DbContext
//Adding   Microsoft.EntityFrameworkCore.SqlServer  to can use UseSqlServer method


namespace SeedingDataAPI.Model
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {

        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<EmployeesInProject> EmployeesInProject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
/*
Connection string without using  API and appsettings.json
public class EFContext : DbContext
{
 
  private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCoreDataSeed;Trusted_Connection=True;";
  
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(connectionString);
  }
 
  public DbSet<Department> Department { get; set; }
 
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    //Configure domain classes using modelBuilder here   
  }
 
}   
 */
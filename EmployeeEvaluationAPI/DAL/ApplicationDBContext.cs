using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeEvaluationAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EmployeeEvaluationAPI.DAL
{

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Employees
            //modelBuilder.Entity<Employee>()
            //.Property(b => b.Rating)
            //.HasDefaultValue(0);

            Employee employee1 = new Employee
            {
                EmployeeID = -1,
                Name = "Fadi",
                Age = 22,
                Rating = 0.0
            };

            Employee employee2 = new Employee
            {
                EmployeeID = -2,
                Name = "Baha",
                Age = 30,
                Rating = 0.0

            };

            Employee employee3 = new Employee
            {
                EmployeeID = -3,
                Name = "Joseph",
                Age = 26,
                Rating= 0.0

            };

            modelBuilder.Entity<Employee>()
              .HasData(
                employee1,
                employee2,
                employee3
              );

            //Evalutaions
            modelBuilder.Entity<Evaluation>()
              .HasData(
                new Evaluation
                {
                    EvaluationID = -1,
                    ByEmployeeID = employee1.EmployeeID,
                    ForEmployeeID = employee2.EmployeeID,
                    Value = 80
                },
                new Evaluation
                {
                    EvaluationID = -2,
                    ByEmployeeID = employee2.EmployeeID,
                    ForEmployeeID = employee3.EmployeeID,
                    Value = 90
                },
                new Evaluation
                {
                    EvaluationID = -3,
                    ByEmployeeID = employee3.EmployeeID,
                    ForEmployeeID = employee1.EmployeeID,
                    Value = 80
                }
              );
        }

        public DbSet<Employee> Employees{get; set; }
        public DbSet<Evaluation> Evaluations
        {
            get;
            set;
        }
    }
}
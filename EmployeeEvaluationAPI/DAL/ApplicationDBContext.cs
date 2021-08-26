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
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }

    }
}

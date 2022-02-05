using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TableSpillting_with_CodeFirst
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                        .HasKey(pk => pk.EmployeeID)
                        .ToTable("Employee");
            modelBuilder.Entity<EmployeeContactDetail>()
                    .HasKey(pk => pk.EmployeeID)
                    .ToTable("Employee");
            modelBuilder.Entity<Employee>()
                        .HasRequired(p => p.EmployeeContactDetail)
                        .WithRequiredPrincipal(c => c.Employee);

            base.OnModelCreating(modelBuilder);
        }
    }
}
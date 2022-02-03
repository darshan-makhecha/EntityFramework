using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StoreProcedure
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> EMployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
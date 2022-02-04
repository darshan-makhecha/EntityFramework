﻿using System;
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
            // store procedure when insert , update and delete employees
            //modelBuilder.Entity<Employee>().MapToStoredProcedures();
            
            //name change 
            modelBuilder.Entity<Employee>().MapToStoredProcedures
                    (p => p.Insert(i =>      i.HasName("InsertEmployee")
                                            .Parameter(n => n.Name, "EmployeeName")
                                            .Parameter(n => n.Gender, "EmployeeGender")
                                            .Parameter(n => n.Salary, "EmployeeSalary"))
                            .Update(u =>     u.HasName("UpdateEmployee")
                                            .Parameter(n => n.ID, "EmployeeID")
                                            .Parameter(n => n.Name, "EmployeeName")
                                            .Parameter(n => n.Gender, "EmployeeGender")
                                            .Parameter(n => n.Salary, "EmployeeSalary"))
                            .Delete(d =>     d.HasName("DeleteEmployee")
                                            .Parameter(n => n.ID, "EmployeeID"))
                    );
            base.OnModelCreating(modelBuilder);
        }
    }
}
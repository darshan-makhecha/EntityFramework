﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpillitExampleCodeFirst
{
    public class EmployeeRepository
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();
        public List<Employee> GetEmployees() {
            return employeeDBContext.Employees.ToList();
        }
        public void InsertEmployee(Employee employee)
        { // insert data 
            employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
        }
        public void UpdateEmployee(Employee employee)
        { // update data
            Employee employeeToUpdate = employeeDBContext.Employees
                        .SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeToUpdate.EmployeeId = employee.EmployeeId;
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Mobile = employee.Mobile;
            employeeToUpdate.Landline = employee.Landline;

            employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        { // delete data
            Employee employeeToDelete = employeeDBContext.Employees
                        .SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeDBContext.Employees.Remove(employeeToDelete);
            employeeDBContext.SaveChanges();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreProcedure
{
    public class EMployeeRepository
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public List<Employee> GetEmployees()
        {
            return employeeDBContext.EMployees.ToList();
        }
        public void insertEmployee(Employee employee) {
            employeeDBContext.EMployees.Add(employee);
            employeeDBContext.SaveChanges();
        }
        public void UpdateEmployee(Employee employee)
        {
            // id ne update karva
            Employee employeeToUpdaate = employeeDBContext.EMployees.FirstOrDefault(x => x.ID == employee.ID);
            employeeToUpdaate.Name = employee.Name;
            employeeToUpdaate.Gender = employee.Gender;
            employeeToUpdaate.Salary = employee.Salary;
            employeeDBContext.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            // id ne update karva
            Employee employeeToDelete = employeeDBContext.EMployees.FirstOrDefault(x => x.ID == employee.ID);
            employeeDBContext.EMployees.Remove(employeeToDelete);
           employeeDBContext.SaveChanges();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfRegister_with_CodeFirst
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int? ManagerID { get; set; }

        // Navigation property
        public Employee Manager { get; set; }
    }
}
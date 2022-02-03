using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03CodeFirst
{
    public class Department
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Location { get; set; }
        // navigation property
        public List<Employee> Employees { get; set; }

    }
}
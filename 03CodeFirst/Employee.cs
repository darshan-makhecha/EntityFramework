using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _03CodeFirst
{

    public class Employee
    {
        public int Id { get; set; }
        // column name change like this =>  [Column("First_Name")]

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        // navigation property  
        public Department Department { get; set; }
        public string JobTitle { get; set; }
       
    }
}
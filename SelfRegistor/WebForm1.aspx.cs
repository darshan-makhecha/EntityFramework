using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SelfRegistor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            GridView1.DataSource = employeeDBContext.Employees.Select(emp => new { EmployeeName = emp.EmployeeName, ManagerName = emp.ManagerID == null ? "Super Boss" : emp.Employee1.EmployeeName }).ToList();
            GridView1.DataBind();
        }
    }
}
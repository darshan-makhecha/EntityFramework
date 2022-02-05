using System;
using System.Linq;

namespace ConditionalMapping
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            //GridView1.DataSource = employeeDBContext.Employees.Where(emp => emp.IsTerminated == false).ToList();
            GridView1.DataSource = employeeDBContext.Employees.ToList();
            GridView1.DataBind();
        }
    }
}
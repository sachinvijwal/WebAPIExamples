using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using WebAPIProject.DB;

namespace EmployeeService.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        //[Authorize(Roles = "admin")]
        [Authorize]
        public List<Employee> GetEmployees()
        {
            //var identity = User.Identity as ClaimsIdentity;
            //if (identity != null)
            //{
            //    IEnumerable<Claim> claims = identity.Claims;
            //    // or
            //    var aa = identity.FindFirst("ClaimName").Value;
            //}


            using (var db = new TestDBEntities())
            {
                var employees = db.Employees.ToList();
                return employees;
            }
        }

        //[HttpGet]
        //[Authorize]
        //public Employee Emp()
        //{
        //    using (var db = new TestDBEntities())
        //    {
        //        var employees = db.Employees.FirstOrDefault();
        //        return employees;
        //    }
        //}
    }
}

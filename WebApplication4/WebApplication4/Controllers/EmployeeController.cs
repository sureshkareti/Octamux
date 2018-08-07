using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;
namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee emp)
        {
            using(dataquotumEntities db=new dataquotumEntities())
            {
                try
                {
                    db.Employees.Add(emp);
                    db.SaveChanges();
                }
                catch(Exception ex)
                {

                }
            }


            return View();
        }

        public ActionResult Delete()
        {
            using (dataquotumEntities db = new dataquotumEntities())
            {
                try
                {
                   List< Employee> emp = db.Employees.Where(a => a.EmpName == "Naveen").ToList();

              
                   /// db.Employees.Remove(emp);

                   // emp.EmpName = "madhu";

                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
            return View();
        }
    }
}
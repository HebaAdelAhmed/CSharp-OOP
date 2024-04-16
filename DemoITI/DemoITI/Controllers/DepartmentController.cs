using DemoITI.Models;
using DemoITI.Models.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DemoITI.Controllers
{
    public class DepartmentController : Controller
    {
        DemoContext context = new DemoContext();
        //GetAll()
        public IActionResult Index()
        {
            List<Department> departments = context.Departments.ToList();
            return View("Index" , departments);
        }
        public IActionResult GetStudentsUsingDepartmentId(int DepartmentId)
        {
            List<Student> students = context.Students.Where(S => S.DepartmentId == DepartmentId).ToList();
            return View("ShowAllStudentUsingId" , students);
        }
    }
}

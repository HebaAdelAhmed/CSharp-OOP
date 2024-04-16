using DemoITI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoITI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentSampleData studentSampleData = new StudentSampleData();
            List<Student> students = studentSampleData.GetAll();
            return View("Index" , students);
        }
        public IActionResult GetById(int id)
        {
            StudentSampleData studentSample = new StudentSampleData();
            Student student = studentSample.GetById(id);
            return View("Details" ,student);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.Controllers
{
    public class MoviesController:Controller
    {
        // Action : Must Be Public , Non-static
        public IActionResult GetMovie(int id , string Name , Employee Employee)
        {
            return Content($"Movie With Id : {id}");
        }
        public IActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Index";
            //result.ContentType = "text/html";
            return Content(content: "Index" , contentType: "text/html");
        }
        public IActionResult RedirectToIndex()
        {
            //RedirectResult result = new RedirectResult("https://localhost:44383/Movies/Index");
            //return Redirect("https://localhost:44383/Movies/Index");
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}

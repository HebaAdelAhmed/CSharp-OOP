using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoITI.Controllers
{
    public class FirstController : Controller
    {
        /// <summary>
        /// Action In Controller :
        /// 1) Must Be Public
        /// 2) Can't Be Static
        /// 3) Can't Be Overload
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome01()
        {
            return "Welcome 01 Action From First Controller";
        }

        /// Return Type Of Actions:
        /// String ==> ContentResult
        /// View ==> ViewResult
        /// Javascript ==> JavascriptResult
        /// Json ==> JsonResult
        /// Files ==> FileResult
        /// .... exc
        
        public ContentResult Welcome02()
        {
            /// Declare Object
            /// Set Value
            /// Return Object.
            ContentResult content = new ContentResult();
            content.Content = "Welcome 02 Action From First Controller";
            return content;
        }

        public ViewResult Welcome03()
        {
            /// Declare Object
            /// Set Value
            /// Return Object.
            ViewResult content = new ViewResult();
            content.ViewName = "MyView";
            return content;
        }


        public JsonResult Welcome04()
        {
            /// Declare Object
            /// Set Value
            /// Return Object.
            JsonResult content = new JsonResult(new { Id = 1821 , Name = "Heba Adel Ahmed Mohammed" });
            return content;
        }

        public IActionResult GetMix()
        {
            if (DateTime.Now.Day == 6)
            {
                
                return Content("This Page Is Colsed");
            }
            else
            {
                return View("MyView");
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace DAY2ANJAN.Web.Controllers{
    public class TestController : Controller{

    public static int a = 0;

        public IActionResult ShowButton(){
             ++a;
            return View(a);
        }

        public IActionResult ClickAction(){
            //++a;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //[Controller]/[ActionName]/[Parameters]
        // MVC 所用的默认 URL 路由逻辑使用如下格式来确定调用的代码：
        //https:/localhost:{PORT}/HelloWorld/(这里是默认index的)
        public IActionResult Index()
        {
            //通常返回 IActionResult 或从 ActionResult 派生的类，而不是 string 这样的类型。
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //ViewData 字典是动态对象，这意味着任何类型都可以使用。 在添加某些内容之前，ViewData 对象没有已定义的属性。
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();  
        }
    }
}

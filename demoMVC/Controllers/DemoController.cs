using Microsoft.AspNetCore.Mvc;
namespace demoMVC.Controllers
{
    public class DemoController : Controller 
    {
        // khoi tao cac phuong thuc
         public IActionResult Index()
    {
         return View();   
    }
    [HttpPost]
    public IActionResult Index(string fName , string Email)
    {
        string strResult = "hello" + fName + "-" + Email;
        ViewBag.thongBao = strResult;
        return View();
    }
    }  
}
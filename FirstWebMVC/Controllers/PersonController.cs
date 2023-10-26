using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers;
public class PersonController : Controller
{
    public IActionResult Index(){
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps){
        string Result= "hello" + ps.PersonID + ps.FullName;
        ViewBag.thongbao = Result;
        return View();
    }
    
}
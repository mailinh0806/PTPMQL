using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers;
public class EmployeeController : Controller
{
     public IActionResult Index(){
        return View();
    }
    [HttpPost]
    public IActionResult Index(Employee emp){
        string Result= "hello" + emp.EmployeeID + emp.TenNV;
        ViewBag.thongbao = Result;
        return View();
    }
    
}
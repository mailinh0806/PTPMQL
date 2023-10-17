using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(string hoTen, double heSoLuong, int phuCap){
            int luongCoBan = 5000000;
            int luong = Convert.ToInt32(luongCoBan * heSoLuong + phuCap);
            string result = "Nhan vien " + hoTen + " co muc luong la " + luong;
            ViewBag.noti = result;
            return View();
        }
    }
}
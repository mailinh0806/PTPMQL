using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
            public IActionResult Index(){
            return View();
        }
        [HttpPost]

        public IActionResult Index(double heSoA, double heSoB, double heSoC){
            string phuongtrinh = "Phuong trinh da nhap la: " + heSoA + "x^2 + " + heSoB + "x + " + heSoC + " = 0";
            string result;
            double delta = heSoB * heSoB - 4 * heSoA * heSoC;
            double x1, x2;
            if (heSoA == 0)
            {
                if (heSoB == 0)
                {
                    result = "Phuong trinh vo nghiem!";
                }
                else
                {
                    result = "Phuong trinh co mot nghiem: x = " + (-heSoC / heSoB);
                }
            }
            else if (delta > 0)
            {
                x1 = (double)((-heSoB + Math.Sqrt(delta)) / (2 * heSoA));
                x2 = (double)((-heSoB - Math.Sqrt(delta)) / (2 * heSoA));
                result = "Phuong trinh co 2 nghiem la: x1 = " + x1 + " va x2 = " + x2;
            }
            else if (delta == 0)
            {
                x1 = (-heSoB / (2 * heSoA));
                result = "Phong trinh co nghiem kep: x1 = x2 = " + x1;
            }
            else
            {
                result = "Phuong trinh vo nghiem!";
            }
            ViewBag.debai = phuongtrinh;
            ViewBag.noti = result;
            return View();
        }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Demo()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
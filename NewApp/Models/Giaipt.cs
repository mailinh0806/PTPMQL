using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
namespace NewApp.Models
{
    public class Giaipt
    {
        public String PTbac1(double a, double b){
            if(a != 0 ){
                return "x = " + (-b/a);
            } else {
                if(b == 0){
                    return "Phuong trinh co vo so nghiem!";
                } else {
                    return "Phuong trinh vo nghiem!";
                }
            }
        }
        public string PTbac2(double a, double b, double c){
            double delta = b * b - 4 * a * c;
            double x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh vo nghiem!";
                }
                else
                {
                    return "Phuong trinh co mot nghiem: x = {0}" + (-c / b);
                }
            }
            if (delta > 0)
            {
                x1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                return "Phuong trinh co 2 nghiem la: x1 = " + x1 + "va x2 = " + x2;
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                return "Phong trinh co nghiem kep: x1 = x2 = " + x1;
            }
            else
            {
                return "Phuong trinh vo nghiem!";
            }
        }
    }
}
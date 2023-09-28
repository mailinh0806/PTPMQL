using System.Reflection.Metadata;
namespace NewApp.Models
{
    public class Employee
    {
        public string MaNhanVien { get; set; }
        public String  TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public void Nhapthongtin()
        {  
            System.Console.WriteLine("MaNhanVien: ");
            MaNhanVien = Console.ReadLine();
            System.Console.WriteLine("TenNhanVien: ");
            TenNhanVien = Console.ReadLine();
            System.Console.WriteLine("Tuoi: ");
            try{
               Tuoi = Convert.ToInt16(Console.ReadLine()); 
            }catch(Exception e)
            {
                Tuoi = 0;
            }
            
            System.Console.WriteLine("Luong: "); 
            Luong = Convert.ToInt16(Console.ReadLine());
         }
        public void HienThi()
        {
            System.Console.WriteLine(MaNhanVien + "-" + TenNhanVien + "-" + Tuoi + "-" + Luong + "-");
        }
    }
}



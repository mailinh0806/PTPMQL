namespace NewApp.Models
{
    public class Fruit
    {
        public string Ten { get; set; }
        public string XuatXu { get; set; }
        public string MauSac { get; set; }
        public string HanSD { get; set; }
       
        public void Nhapthongtin()
        {
            System.Console.WriteLine("Ten: ");
            Ten = Console.ReadLine();
            System.Console.WriteLine("XuatXu: ");
            XuatXu = Console.ReadLine();
            System.Console.WriteLine("MauSac: ");
            MauSac = Console.ReadLine();
            System.Console.WriteLine("HanSD: ");
            HanSD = Console.ReadLine();
        
        }
        public void HienThi()
        {
            System.Console.WriteLine(Ten + "-" + XuatXu + "-" + MauSac + "-" + HanSD + "-");
        }
    }
}
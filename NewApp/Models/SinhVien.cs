namespace NewApp.Models
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string sdt { get; set; }
        public int Tuoi { get; set; }

        public void Nhapthongtin()
        {
            System.Console.WriteLine("TenSV: ");
            HoTen = Console.ReadLine();
            System.Console.WriteLine("DiaChi: ");
            DiaChi = Console.ReadLine();
            System.Console.WriteLine("sdt: ");
            sdt = Console.ReadLine();
            System.Console.WriteLine("Tuoi: "); 
            Tuoi = Convert.ToInt16(Console.ReadLine());
        }
        public void HienThi()
        {
            System.Console.WriteLine(HoTen + "-" + DiaChi + "-" + sdt + "-" + Tuoi);
        }
    }
}
namespace NewApp.Models
{
    public class Student
    {
        public string TenSV { get; set; }
        public string MaSV { get; set; }
        public string Lop { get; set; }
        public int Tuoi { get; set; }

        public void Nhapthongtin()
        {
            System.Console.WriteLine("TenSV: ");
            TenSV = Console.ReadLine();
            System.Console.WriteLine("MaSV: ");
            MaSV = Console.ReadLine();
            System.Console.WriteLine("Lop: ");
            Lop = Console.ReadLine();
            System.Console.WriteLine("Tuoi: "); 
            try{
                Tuoi = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e)
            {
                Tuoi = 0;
            }
        }
        public void HienThi()
        {
            System.Console.WriteLine(TenSV + "-" + MaSV + "-" + Lop + "-" + Tuoi + "-");
        }
    }
}
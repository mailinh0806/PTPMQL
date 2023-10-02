using NewApp.Models;
public class Program{
    private static void Main(string[] args)
    {
     int n;
        Console.Write("\n" + "Nhap kich thuoc mang Customer: ");
        n = Convert.ToInt32(Console.ReadLine());
        Customer[] cusArr = new Customer[n];
        for(int i = 0; i < cusArr.Length; i++){
            Console.WriteLine("Nhap thong tin khach hang thu {0}", i+1);
            Customer cus = new Customer();
            cus.NhapThongTin();
           cusArr[i] = cus;
        }
        Console.Write("Hien thi mang Employee");
        foreach(Customer cus in cusArr){
            cus.HienThi();
        }   
    }
}
 
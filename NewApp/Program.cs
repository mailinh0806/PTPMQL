using NewApp.Models;
public class Program{
    private static void Main(string[] args)
    {
     int n;
        Console.Write("\n" + "Nhap kich thuoc mang Employee: ");
        n = Convert.ToInt32(Console.ReadLine());
        Employee[] empArr = new Employee[n];
        for(int i = 0; i < empArr.Length; i++){
            Console.WriteLine("Nhap thong tin Employee thu {0}", i+1);
            Employee emp = new Employee();
            emp.Nhapthongtin();
            empArr[i] = emp;
        }
        Console.Write("Hien thi mang Employee");
        foreach(Employee emp in empArr){
            emp.HienThi();
        }   
    }
}
 
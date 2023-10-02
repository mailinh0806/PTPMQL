using NewApp.Models;
public class Program{
    private static void Main(string[] args)
    {
     int n;
        Console.Write("\n" + "Nhap kich thuoc mang Student: ");
        n = Convert.ToInt32(Console.ReadLine());
        Student[] stdArr = new Student[n];
        for(int i = 0; i < stdArr.Length; i++){
            Console.WriteLine("Nhap thong tin sinh vien thu {0}", i+1);
            Student std = new Student();
            std.Nhapthongtin();
            stdArr[i] = std;
        }
        Console.Write("Hien thi mang Student");
        foreach(Student std in stdArr){
            std.HienThi();
        }   
    }
}
 
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using NewApp.Models;
public class Program{
    private static void Main(string[] args)
    {
     int n;
        System.Console.Write("Nhap kich thuoc danh sach: ");
        n = Convert.ToInt32(Console.ReadLine());
        ArrayList stdList = new ArrayList();
        for(int i = 0; i < n; i++)
        {
        System.Console.Write("Nhap thong tin sinh vien thu {0}", i++);
        Student std = new Student();
        std.Nhapthongtin();
        stdList.Add(std);  
        } 
        System.Console.Write("Hien thi danh sach ");  
        foreach(Student std in stdList){
            std.HienThi();
        }
        int indexToEdit = 0;
        if (indexToEdit >= 0 && indexToEdit < stdList.Count)
        {
            Console.WriteLine("\n" + "Nhap thong tin moi cho sinh vien thu {0}", indexToEdit + 1);
            Student newStudentInfo = new Student();
            newStudentInfo.Nhapthongtin();
            stdList[indexToEdit] = newStudentInfo;
        }
        else
        {
            Console.WriteLine("Vi tri khong hop le");
        }

        int indexToDelete = 1;
        if (indexToDelete >= 0 && indexToDelete < stdList.Count)
        {
            stdList.RemoveAt(indexToDelete);
            Console.WriteLine("Da xoa sinh vien thu {0}", indexToDelete + 1);
        }
        else
        {
            Console.WriteLine("Vi tri khong hop le");
        }
    }
}
 

using System.IO.Pipes;
using NewApp.Models;
public class Program 
{
    private static void Main(string[] args)
    {
       Student std = new Student();
       std.Nhapthongtin();
       std.HienThi();
    }
}


using System.IO.Pipes;
using NewApp.Models;
public class Program 
{
    private static void Main(string[] args)
    {
       Employee emp = new Employee();
       emp.Nhapthongtin();
       emp.HienThi();
    }
}

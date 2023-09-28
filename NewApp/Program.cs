
using System.IO.Pipes;
using NewApp.Models;
public class Program 
{
    private static void Main(string[] args)
    {
       Person ps = new Person();
       ps.NhapThongTin();
       ps.HienThi();
    }
}

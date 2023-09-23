
﻿using System.Threading.Tasks.Dataflow;
using NewApp.Models;
public class Program{
    private static void Main(string[] args){
        Person ps1 = new Person();
        Student std = new Student();
        Employee emp = new Employee();
        SinhVien sv1 = new SinhVien();

        sv1.HoTen = "vu mai linh";
        sv1.DiaChi = "qluu";
        sv1.sdt = "487529382";
       
        sv1.HienThi();

        // string ten = "Vu Mai Linh";
        // int tuoi = 21;
        // ps1.Display(ten, tuoi);
      
        // System.Console.WriteLine("{0} sinh nam {1}", ten, ps1.GetYearOfBirthDay(21));


      
    }
}


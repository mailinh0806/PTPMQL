using System.Runtime.Intrinsics.Arm;

namespace NewApp.Models
{
    public class Customer : Person
    {
        public string IDCustomer { get; set; }
        public string PhoneNumber { get; set; }
        public Customer(){
            IDCustomer = "2021050850";
        }
         public void NhapThongTin(){
            base.NhapThongTin();
            System.Console.Write("ID Khach hang: ");
            IDCustomer = Console.ReadLine();
            System.Console.Write("SDT: ");
            PhoneNumber = Console.ReadLine(); 
            
         }
         public void HienThi(){
            base.HienThi();
             System.Console.Write(IDCustomer + " - " + PhoneNumber + " - ");
         }
        }
       
    }




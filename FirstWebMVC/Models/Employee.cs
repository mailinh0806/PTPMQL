using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Employee")]
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public int Age { get; set; }
    }
}
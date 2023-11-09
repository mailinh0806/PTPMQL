using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("HeThongPhanPhoi")]
    public class HeThongPhanPhoi 
    {
        [Key]
        public string MaHTPP { get; set; }
        public string TenHTPP { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamThiLoan_03.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public virtual NhanVien NhanViens { get; set; }
    }
}
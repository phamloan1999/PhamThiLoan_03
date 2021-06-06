

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamThiLoan_03.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public ICollection<PhongBan>PhongBans { get; set; }

    }
}
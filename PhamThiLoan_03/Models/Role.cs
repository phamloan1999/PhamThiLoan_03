

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamThiLoan_03.Models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        public string RoleID { get; set; }
        public string RoleName { get; set; }

    }
}
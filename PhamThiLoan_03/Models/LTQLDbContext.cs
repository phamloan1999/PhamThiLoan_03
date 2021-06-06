using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhamThiLoan_03.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<NhanVien> NhanViens{ get; set; }
       public virtual DbSet<Role> Roles { get; set; }
       // public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
      //  public virtual DbSet<spt_monitor> spt_monitor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhongBan>()
                .Property(e => e.MaPhongBan);


            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleID)
                .IsUnicode(false);

            /* modelBuilder.Entity<spt_fallback_dev>()
                 .Property(e => e.xfallback_drive)
                 .IsFixedLength()
                 .IsUnicode(false);*/

            /*  modelBuilder.Entity<spt_fallback_dev>()
                  .Property(e => e.name)
                  .IsUnicode(false);*/

            /* modelBuilder.Entity<spt_fallback_dev>()
                 .Property(e => e.phyname)
                 .IsUnicode(false);
 */
            /*modelBuilder.Entity<spt_fallback_usg>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);*/
        }
    }
}

namespace PhamThiLoan_03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128, unicode: false),
                        HoTen = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            AddColumn("dbo.PhongBans", "NhanViens_MaNhanVien", c => c.String(maxLength: 128, unicode: false));
            CreateIndex("dbo.PhongBans", "NhanViens_MaNhanVien");
            AddForeignKey("dbo.PhongBans", "NhanViens_MaNhanVien", "dbo.NhanViens", "MaNhanVien");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhongBans", "NhanViens_MaNhanVien", "dbo.NhanViens");
            DropIndex("dbo.PhongBans", new[] { "NhanViens_MaNhanVien" });
            DropColumn("dbo.PhongBans", "NhanViens_MaNhanVien");
            DropTable("dbo.NhanViens");
        }
    }
}

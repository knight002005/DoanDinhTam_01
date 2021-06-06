namespace DoanDinhTam_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SinhViens", "Malop", c => c.Int(nullable: false));
            CreateIndex("dbo.SinhViens", "Malop");
            AddForeignKey("dbo.SinhViens", "Malop", "dbo.LopHocs", "Malop", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "Malop", "dbo.LopHocs");
            DropIndex("dbo.SinhViens", new[] { "Malop" });
            DropColumn("dbo.SinhViens", "Malop");
        }
    }
}

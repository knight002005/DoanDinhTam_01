namespace DoanDinhTam_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Acounts", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Acounts", "Email");
        }
    }
}

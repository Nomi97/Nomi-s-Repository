namespace GCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembersModels",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        About = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.PostContactModels",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PostContactModels");
            DropTable("dbo.MembersModels");
        }
    }
}

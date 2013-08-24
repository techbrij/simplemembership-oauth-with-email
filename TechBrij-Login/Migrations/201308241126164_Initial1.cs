namespace TechBrij_Login.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.webpages_OAuthMembership",
                c => new
                    {
                        Provider = c.String(nullable: false, maxLength: 30),
                        ProviderUserId = c.String(nullable: false, maxLength: 100),
                        UserId = c.Int(nullable: false),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.Provider, t.ProviderUserId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.webpages_OAuthMembership");
        }
    }
}

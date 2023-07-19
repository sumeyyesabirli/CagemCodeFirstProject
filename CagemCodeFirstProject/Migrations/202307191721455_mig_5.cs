namespace CagemCodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutMes",
                c => new
                    {
                        AboutMeId = c.Int(nullable: false, identity: true),
                        Title1 = c.String(),
                        Description1 = c.String(),
                        ImageUrl1 = c.String(),
                        Title2 = c.String(),
                        Description2 = c.String(),
                        ImageUrl2 = c.String(),
                    })
                .PrimaryKey(t => t.AboutMeId);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ContactSocials",
                c => new
                    {
                        ContactSocialId = c.Int(nullable: false, identity: true),
                        ContactSocialName = c.String(),
                        ContactSocialURL = c.String(),
                        ContactSocialIcon = c.String(),
                    })
                .PrimaryKey(t => t.ContactSocialId);
            
            CreateTable(
                "dbo.Explores",
                c => new
                    {
                        ExploreId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ExploreId);
            
            CreateTable(
                "dbo.FooterContacts",
                c => new
                    {
                        FooterId = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        Mail = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.FooterId);
            
            CreateTable(
                "dbo.FooterGaleries",
                c => new
                    {
                        FooterGaleryId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.FooterGaleryId);
            
            CreateTable(
                "dbo.FooterTravelTrips",
                c => new
                    {
                        FooterTravelTripId = c.Int(nullable: false, identity: true),
                        FooterTravelTripName = c.String(),
                    })
                .PrimaryKey(t => t.FooterTravelTripId);
            
            CreateTable(
                "dbo.Galeries",
                c => new
                    {
                        GaleryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GaleryId);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PlaceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.ServicesId);
            
            AddColumn("dbo.SocialMedias", "Icon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SocialMedias", "Icon");
            DropTable("dbo.Services");
            DropTable("dbo.Places");
            DropTable("dbo.Galeries");
            DropTable("dbo.FooterTravelTrips");
            DropTable("dbo.FooterGaleries");
            DropTable("dbo.FooterContacts");
            DropTable("dbo.Explores");
            DropTable("dbo.ContactSocials");
            DropTable("dbo.Categories");
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutMes");
        }
    }
}

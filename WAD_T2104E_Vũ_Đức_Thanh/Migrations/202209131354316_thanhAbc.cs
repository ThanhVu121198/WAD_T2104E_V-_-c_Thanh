namespace WAD_T2104E_Vũ_Đức_Thanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thanhAbc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Products_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Products", t => t.Products_ProductId)
                .Index(t => t.Products_ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.String(),
                        Quantity = c.Int(),
                        ReleaseDate = c.DateTime(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Products_ProductId", "dbo.Products");
            DropIndex("dbo.Categories", new[] { "Products_ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}

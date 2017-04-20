namespace updateTheLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        YearPublished = c.Int(),
                        Genre = c.String(),
                        IsCheckedOut = c.Boolean(),
                        LastCheckedOutDate = c.DateTime(),
                        DueBackDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}

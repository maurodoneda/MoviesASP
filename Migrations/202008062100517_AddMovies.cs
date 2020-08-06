namespace moviesASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Movies");
        }

            
        
        public override void Down()
        {
            CreateTable(
               "dbo.Movies",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(),
                   Img = c.String(),
                   ReleaseDate = c.DateTime(nullable: true),
                   ReviewScore = c.Double(nullable: true),
               })
               .PrimaryKey(t => t.Id);

           
        }
    
    }
}

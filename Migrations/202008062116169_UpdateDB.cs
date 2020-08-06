namespace moviesASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReviewScore", c => c.Double());
            Sql("DELETE FROM Movies;");
            Sql("INSERT INTO Movies(Name,Img) VALUES ('NewMovie','newPoster');");
            Sql("INSERT INTO Movies(Name,Img) VALUES ('NewMovie','newPoster');");
            Sql("INSERT INTO Movies(Name,Img) VALUES ('Green Mile','greenMilePoster');");
            Sql("INSERT INTO Movies(Name,Img) VALUES ('The Last Samurai','samuraiPoster');");
            Sql("INSERT INTO Movies(Name,Img) VALUES ('The Last Samurai','samuraiPoster');");
            
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReviewScore", c => c.Double(nullable: false));
        }
    }
}

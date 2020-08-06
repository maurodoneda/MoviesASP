namespace moviesASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name,Img,ReleaseDate) VALUES ('Upgrade','upPoster','20100301');");
            Sql("INSERT INTO Movies(Name,Img,ReleaseDate) VALUES ('Upgrade','upPoster','20180301');");
        }
        
        public override void Down()
        {
        }
    }
}

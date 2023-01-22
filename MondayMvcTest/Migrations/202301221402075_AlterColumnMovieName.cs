namespace MondayMvcTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterColumnMovieName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Moviedetails", "MovieName", c => c.String(nullable: false));
            AlterColumn("dbo.Moviedetails", "DirectorName", c => c.String(nullable: false));
            AlterColumn("dbo.Moviedetails", "GenreName", c => c.String(nullable: false));
            AlterColumn("dbo.Moviedetails", "ReleaseDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Moviedetails", "ReleaseDate", c => c.String());
            AlterColumn("dbo.Moviedetails", "GenreName", c => c.String());
            AlterColumn("dbo.Moviedetails", "DirectorName", c => c.String());
            AlterColumn("dbo.Moviedetails", "MovieName", c => c.String());
        }
    }
}

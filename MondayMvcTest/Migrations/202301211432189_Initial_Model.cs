namespace MondayMvcTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moviedetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        DirectorName = c.String(),
                        GenreName = c.String(),
                        ReleaseDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Moviedetails");
        }
    }
}

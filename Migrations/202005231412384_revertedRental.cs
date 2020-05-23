namespace RentalMovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revertedRental : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Rentals", newName: "NewRentals");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.NewRentals", newName: "Rentals");
        }
    }
}

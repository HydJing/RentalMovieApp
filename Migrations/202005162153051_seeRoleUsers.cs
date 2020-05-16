namespace RentalMovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeRoleUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd6c75853-7dac-44ec-b0dd-ed53861c5392', N'guest@rentalmovie.com', 0, N'AG7SR/UbyREfhnzFw12hgeYQAcyCBa3r3S0ePRHE/jb9/uwSVu4uQQsySFYba4J+Ug==', N'8549025c-bc24-4121-955b-adcbe59a997a', NULL, 0, 0, NULL, 1, 0, N'guest@rentalmovie.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ff8b464c-c8b2-4582-b02c-d62cdd01879c', N'admin@rentalmovie.com', 0, N'AKrsoUYFNuSaZUc4pcze39IG4at4eYzq5lvK1XZJ7FDFCeo6gF3HZeFEE15r8juuVw==', N'34dc27a2-fd2b-4e71-bfc3-ae629a3511e4', NULL, 0, 0, NULL, 1, 0, N'admin@rentalmovie.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1b303f54-a6ae-4718-a941-f1e58a9c75a9', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ff8b464c-c8b2-4582-b02c-d62cdd01879c', N'1b303f54-a6ae-4718-a941-f1e58a9c75a9')
            ");
        }
        
        public override void Down()
        {
        }
    }
}

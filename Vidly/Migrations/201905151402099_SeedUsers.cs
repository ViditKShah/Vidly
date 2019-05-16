namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'00e119c8-5b76-4f82-8e36-fd96a891f02a', N'guest@vidly.com', 0, N'ANyYbQYDALpEEadlFVeIF7B4DSUQGID50pLLDAk4j9daWvsuyjARxNglemSvQxoOYw==', N'69872fe9-36cd-441d-9012-9b3145a2db06', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'22c8337e-46c6-499f-a8ab-d7edf6ae0713', N'admin@vidly.com', 0, N'ABkr1sfUe1AC7wl2gL4cIkFL05ukHI7jykHiUuuFQQs2NLvlAXHMRzFy+2j5jYylUA==', N'b38a8998-8642-4dcd-9d38-4d46d99ca72d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c657dd09-633c-448f-8123-c5eaa5ac0c36', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'22c8337e-46c6-499f-a8ab-d7edf6ae0713', N'c657dd09-633c-448f-8123-c5eaa5ac0c36')
            ");

        }
        
        public override void Down()
        {
        }
    }
}

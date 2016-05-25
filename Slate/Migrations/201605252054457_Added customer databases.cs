namespace Slate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedcustomerdatabases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CompanyName = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(maxLength: 100),
                        ConfirmPassword = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.BusinessStaffs",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 128),
                        Job = c.String(nullable: false),
                        SkillLevel = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Monday = c.String(nullable: false, maxLength: 128),
                        Tuesday = c.String(),
                        Wednesday = c.String(),
                        Thursday = c.String(),
                        Friday = c.String(),
                        Saturday = c.String(),
                        Sunday = c.String(),
                        EmployeeId = c.String(),
                    })
                .PrimaryKey(t => t.Monday);
            
            CreateTable(
                "dbo.StaffInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(maxLength: 100),
                        ConfirmPassword = c.String(),
                        UserId = c.String(),
                        BusinessId = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StaffInfoes");
            DropTable("dbo.Schedules");
            DropTable("dbo.BusinessStaffs");
            DropTable("dbo.BusinessInfoes");
        }
    }
}

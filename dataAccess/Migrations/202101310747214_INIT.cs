namespace dataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INIT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        persons = c.String(),
                        groupName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.personDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        personDataId = c.Int(nullable: false),
                        parameter = c.String(),
                        value = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.people", t => t.personDataId, cascadeDelete: true)
                .Index(t => t.personDataId);
            
            CreateTable(
                "dbo.people",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        fullName = c.String(),
                        birthDate = c.DateTime(),
                        relation = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.personPhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        personDataId = c.Int(nullable: false),
                        phoneNumber = c.String(),
                        phoneNumberType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.people", t => t.personDataId, cascadeDelete: true)
                .Index(t => t.personDataId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.personPhones", "personDataId", "dbo.people");
            DropForeignKey("dbo.personDetails", "personDataId", "dbo.people");
            DropIndex("dbo.personPhones", new[] { "personDataId" });
            DropIndex("dbo.personDetails", new[] { "personDataId" });
            DropTable("dbo.personPhones");
            DropTable("dbo.people");
            DropTable("dbo.personDetails");
            DropTable("dbo.groups");
        }
    }
}

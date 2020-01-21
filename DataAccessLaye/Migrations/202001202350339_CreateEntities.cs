using System.Data.Entity.Migrations;
namespace DataAccessLayer.Migrations
{
    public partial class CreateEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arguments",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Argument_Description = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Collect",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Employe_Id = c.Int(nullable: false),
                    Date_of_collect = c.DateTime(nullable: false),
                    Subject_Id = c.Int(nullable: false),
                    Solid_Waste_Id = c.Int(nullable: false),
                    Argument_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Arguments", t => t.Argument_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Employe_Id, cascadeDelete: true)
                .ForeignKey("dbo.Municipal_Solid_Wastes", t => t.Solid_Waste_Id, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .Index(t => t.Employe_Id)
                .Index(t => t.Subject_Id)
                .Index(t => t.Solid_Waste_Id)
                .Index(t => t.Argument_Id);

            CreateTable(
                "dbo.Employes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Login = c.String(nullable: false),
                    Password = c.String(nullable: false, maxLength: 50),
                    Name = c.String(nullable: false),
                    Position = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false),
                    PhoneNumber = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Municipal_Solid_Wastes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Subjects",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false, maxLength: 50),
                    Email = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Collect", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Collect", "Solid_Waste_Id", "dbo.Municipal_Solid_Wastes");
            DropForeignKey("dbo.Collect", "Employe_Id", "dbo.Employes");
            DropForeignKey("dbo.Collect", "Argument_Id", "dbo.Arguments");
            DropIndex("dbo.Collect", new[] { "Argument_Id" });
            DropIndex("dbo.Collect", new[] { "Solid_Waste_Id" });
            DropIndex("dbo.Collect", new[] { "Subject_Id" });
            DropIndex("dbo.Collect", new[] { "Employe_Id" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Municipal_Solid_Wastes");
            DropTable("dbo.Employes");
            DropTable("dbo.Collect");
            DropTable("dbo.Arguments");
        }
    }
}

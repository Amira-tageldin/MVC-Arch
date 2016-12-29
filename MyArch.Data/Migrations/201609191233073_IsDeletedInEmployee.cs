namespace MyArch.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeletedInEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsDeleted");
        }
    }
}

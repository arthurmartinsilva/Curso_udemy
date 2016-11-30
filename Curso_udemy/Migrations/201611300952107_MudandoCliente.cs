namespace Curso_udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudandoCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "nome", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "nome", c => c.String(nullable: false, maxLength: 255));
        }
    }
}

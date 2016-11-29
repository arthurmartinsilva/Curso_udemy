namespace Curso_udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInscritoToNewsLetter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "inscritoToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "inscritoToNewsLetter");
        }
    }
}

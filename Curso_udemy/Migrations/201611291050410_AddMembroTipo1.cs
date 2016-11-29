namespace Curso_udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembroTipo1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "MembroTipoId", "dbo.MembroTipoes");
            DropIndex("dbo.Clientes", new[] { "MembroTipoId" });
            RenameColumn(table: "dbo.Clientes", name: "MembroTipoId", newName: "MembroTipo_Id");
            AddColumn("dbo.Clientes", "MembroTipoesId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Clientes", "MembroTipo_Id", c => c.Byte());
            CreateIndex("dbo.Clientes", "MembroTipo_Id");
            AddForeignKey("dbo.Clientes", "MembroTipo_Id", "dbo.MembroTipoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "MembroTipo_Id", "dbo.MembroTipoes");
            DropIndex("dbo.Clientes", new[] { "MembroTipo_Id" });
            AlterColumn("dbo.Clientes", "MembroTipo_Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Clientes", "MembroTipoesId");
            RenameColumn(table: "dbo.Clientes", name: "MembroTipo_Id", newName: "MembroTipoId");
            CreateIndex("dbo.Clientes", "MembroTipoId");
            AddForeignKey("dbo.Clientes", "MembroTipoId", "dbo.MembroTipoes", "Id", cascadeDelete: true);
        }
    }
}

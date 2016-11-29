namespace Curso_udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembroTipo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembroTipoes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        InscricaoAno = c.Short(nullable: false),
                        DuracaoMeses = c.Byte(nullable: false),
                        Desconto = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clientes", "MembroTipoId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clientes", "MembroTipoId");
            AddForeignKey("dbo.Clientes", "MembroTipoId", "dbo.MembroTipoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "MembroTipoId", "dbo.MembroTipoes");
            DropIndex("dbo.Clientes", new[] { "MembroTipoId" });
            DropColumn("dbo.Clientes", "MembroTipoId");
            DropTable("dbo.MembroTipoes");
        }
    }
}

namespace Curso_udemy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulandoMembrosTipos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembroTipoes (Id, InscricaoAno, DuracaoMeses, Desconto) VALUES (1,0,0,0)");
            Sql("INSERT INTO MembroTipoes (Id, InscricaoAno, DuracaoMeses, Desconto) VALUES (2,30,1,10)");
            Sql("INSERT INTO MembroTipoes (Id, InscricaoAno, DuracaoMeses, Desconto) VALUES (3,90,3,15)");
            Sql("INSERT INTO MembroTipoes (Id, InscricaoAno, DuracaoMeses, Desconto) VALUES (4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}

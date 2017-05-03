namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListaDeProduto",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        CategoriaId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.ProdutosNaListaDeProdutos",
                c => new
                    {
                        ListaDeProduto_Id = c.Long(nullable: false),
                        Produto_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ListaDeProduto_Id, t.Produto_Id })
                .ForeignKey("dbo.ListaDeProduto", t => t.ListaDeProduto_Id)
                .ForeignKey("dbo.Produto", t => t.Produto_Id)
                .Index(t => t.ListaDeProduto_Id)
                .Index(t => t.Produto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutosNaListaDeProdutos", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.ProdutosNaListaDeProdutos", "ListaDeProduto_Id", "dbo.ListaDeProduto");
            DropForeignKey("dbo.Produto", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.ProdutosNaListaDeProdutos", new[] { "Produto_Id" });
            DropIndex("dbo.ProdutosNaListaDeProdutos", new[] { "ListaDeProduto_Id" });
            DropIndex("dbo.Produto", new[] { "CategoriaId" });
            DropTable("dbo.ProdutosNaListaDeProdutos");
            DropTable("dbo.Produto");
            DropTable("dbo.ListaDeProduto");
            DropTable("dbo.Categoria");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES ('Coca cola','Refrigerante de cola 350ml',5.45,'cocacola.jpg',50,getdate(),1)");
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES ('Lanche de Atum','Lanche de Atum com maionese',8.50,'atum.jpg',10,getdate(),2)");
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES ('Pudim','Pudim de leite condensado 100g',6.75,'pudim.jpg',20,getdate(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}

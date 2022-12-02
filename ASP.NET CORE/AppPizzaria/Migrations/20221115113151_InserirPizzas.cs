using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppPizzaria.Migrations
{
    public partial class InserirPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pizzas(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsPizzaPreferida,EmStock,CategoriaId) " +
                "VALUES('Crispy Bacon','Massa Clássica , Cogumelos, bacon, queijo','A nossa massa especial, molho de tomate e orengos e topping para pizza, bacon e cogumelos. Acompanhada por coca-cola', 12.90 ,'','', 1, 1,1)");

            migrationBuilder.Sql("INSERT INTO Pizzas(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsPizzaPreferida,EmStock,CategoriaId) " +
                "VALUES('Americana','Massa Fina,presunto, azeitonas, pimento','Bem ao estilo americano a nossa Pizza Americana combina o melhor do pepperoni, pimento, azeitonas e muito topping. Acompanhada por 7Up', 11.90 ,'','', 0, 1,1)");

            migrationBuilder.Sql("INSERT INTO Pizzas(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsPizzaPreferida,EmStock,CategoriaId) " +
                "VALUES('Burguer','Massa Extra Fina , carne , cebola , bacon','Se sonhaste com um mix perfeito entre pizza e hambúrguer aqui o tens: massa telepizza com molho de toate e oregãos e o topping para pizza, carne, cebola, bacon e extra topping para pizza.', 9.99 ,'','', 0, 1,1)");

            migrationBuilder.Sql("INSERT INTO Pizzas(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsPizzaPreferida,EmStock,CategoriaId) " +
                "VALUES('Bacana','Massa Integral, queijo, ananás, cogumelos, pessego','A pizza Bacana reúne os melhores ingredientes massa com molho de tomate e oregãos, topping para pizza, bacon, cogumelos, ananás e extra topping para pizza', 12.90 ,'','', 1, 1,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Pizzas");
        }
    }
}

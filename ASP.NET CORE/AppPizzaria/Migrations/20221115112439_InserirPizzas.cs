using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppPizzaria.Migrations
{
    public partial class InserirPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pizzas(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsPizzaPreferida, EmStock, CategoriaId) " +
                "VALUES ('Crispy Bacon','Massa classica, cogumelos, bacon, quiejo', 'Com a nossa massa especial, molho de tomate e oregaos e topping para pizza, bacon e cogumelos. Acompanhada por coca-cola',12.90, '', '', 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Pizzas(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsPizzaPreferida, EmStock, CategoriaId) " +
                "VALUES ('Americana','Massa fina, presunto, azeitonas, pimento', 'Bem ao estilo americano a nossa Pizza America combina o melhor do pepperoni, pimento, azeitonas e muito topping para pizza. Acompanhada por 7Up',11.90, '', '', 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Pizzas(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsPizzaPreferida, EmStock, CategoriaId) " +
                "VALUES ('Burger','Massa extra fina, carne, cebola, bacon', 'Se sonhaste com um mix perfeito entre pizza e hamburger aqui o tens: mass telepizza com molho de tomate e oregaos e topping para pizza, carne, cebola, bacon e extra topping para pizza.',9.99, '', '', 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Pizzas(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsPizzaPreferida, EmStock, CategoriaId) " +
               "VALUES ('Bacana','MassaIntegral, quejo, ananas, bacon, cogumelos, pessego', 'A pizza Bacana reune os melhores ingredientes massa com molho de tomate e oregaos, topping para pizza, bacon, cogumelos, ananas e extra topping para pizza.',21.90, '', '', 0, 1, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Pizzas");
        }
    }
}

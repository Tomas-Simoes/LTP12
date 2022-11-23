using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppPizzaria.Migrations
{
    public partial class InserirPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pizzas(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsPizzaPreferida, EmStock, CategoriaId) " +
                                 "VALUES ('Crispy Bacon', 'Massa clássica, cogumelos, bacon, queijo', " +
                                         "'Com a nossa massa especial, molho de tomate e oregãos e topping para pizza, bacon e cogumelos. Acompanhada por coca-cola.', " +
                                         "12.90, '', '', 1, 1, 1), " +

                                         "('Americana', 'Massa fina, presunto, azeitonas, pimento', " +
                                         "'Bem ao estilo americano a nossa Pizza America combina o melhor do pepperoni, pimento, azeitonas e muito topping para pizza. Acompanhada por 7-UP' " +
                                         "11.90, '', '', 0, 1, 1), " +
                                         
                                         "('Burger', 'Massa extra fina, carne, cebola, bacon', " +
                                         "'Se sonhaste com um mix perfeito entre pizza e hamburger aqui o tens: massa telepizza com molho de tomate e oregaos e topping para pizza, carne, cebola, bacon e extra topping para pizza' " +
                                         "9.90, '', '', 0, 1, 1)");
       
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Pizzas");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppPizzaria.Migrations
{
    public partial class InserirCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
               "VALUES('Pequena','Pizza de 15cm e ate 3 ingredientes')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Media','Pizza de 25cm e ate 5 ingredientes')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Familiar','Pizza de 40cm e ate 7 ingredientes')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}

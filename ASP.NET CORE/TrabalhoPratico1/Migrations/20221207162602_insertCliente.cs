using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabalhoPratico1.Migrations
{
    public partial class insertCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes(ClienteNome, Morada) VALUES " +
                                    "('Anibal', 'Lisboa'), " +
                                    "('Belmiro', 'Braga'), " +
                                    "('Casimiro', 'Coimbra'), " +
                                    "('Portas', 'Porto')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clientes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabalhoPratico1.Migrations
{
    public partial class insertConta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Contas(Saldo, AgenciaId, ClienteId) VALUES " +
                                   "(0, 3, 1), " +
                                   "(100, 1, 2), " +
                                   "(1000, 2, 3), " +
                                   "(500, 4, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Contas");
        }
    }
}

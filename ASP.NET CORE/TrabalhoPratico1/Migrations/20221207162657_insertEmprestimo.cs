using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabalhoPratico1.Migrations
{
    public partial class insertEmprestimo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Emprestimos(Valor, AgenciasAgenciaId, ClientesClienteId) VALUES " +
                                                    "(1000, 3, 1), " +
                                                    "(5000, 1, 1), " +
                                                    "(1000, 2, 2), " +
                                                    "(10000, 4, 4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Emprestimos");
        }
    }
}

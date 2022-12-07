using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabalhoPratico1.Migrations
{
    public partial class insertAgencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Agencias(Morada) VALUES " +
                                                            "('Lisboa'), " +
                                                            "('Porto'), " +
                                                            "('Braga'), " +
                                                            "('Coimbra')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Agencias");
        }
    }
}

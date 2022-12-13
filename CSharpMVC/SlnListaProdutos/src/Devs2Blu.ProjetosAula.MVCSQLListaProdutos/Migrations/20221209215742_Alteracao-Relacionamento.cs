using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Migrations
{
    public partial class AlteracaoRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_categoria = table.Column<int>(type: "int", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.id);
                    table.ForeignKey(
                        name: "FK_produto_categoria_id_categoria",
                        column: x => x.id_categoria,
                        principalTable: "categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produto_id_categoria",
                table: "produto",
                column: "id_categoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "categoria");
        }
    }
}

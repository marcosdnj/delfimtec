using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DelfimTec.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, Descricao) VALUES ('NVIDIA', 'Placa de Vídeo NVIDIA') ");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, Descricao) VALUES ('AMD', 'Placa de Vídeo AMD') ");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}

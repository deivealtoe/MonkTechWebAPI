using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MonkTechWebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saloes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cnpj = table.Column<string>(type: "text", nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saloes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dia = table.Column<DateTime>(type: "Date", nullable: false),
                    HoraInicio = table.Column<string>(type: "text", nullable: false),
                    HoraFim = table.Column<string>(type: "text", nullable: false),
                    NomeDoCliente = table.Column<string>(type: "text", nullable: false),
                    TelefoneDoCliente = table.Column<string>(type: "text", nullable: false),
                    Disponivel = table.Column<bool>(type: "boolean", nullable: false),
                    SalaoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Saloes_SalaoId",
                        column: x => x.SalaoId,
                        principalTable: "Saloes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pais = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    SalaoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Saloes_SalaoId",
                        column: x => x.SalaoId,
                        principalTable: "Saloes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Saloes",
                columns: new[] { "Id", "Cnpj", "RazaoSocial" },
                values: new object[,]
                {
                    { 1, "01234567890123", "Best" },
                    { 2, "09876543210987", "Awesome" },
                    { 3, "13579123456789", "Good" }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Id", "Dia", "Disponivel", "HoraFim", "HoraInicio", "NomeDoCliente", "SalaoId", "TelefoneDoCliente" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), false, "14:00", "13:00", "Maria", 1, "999998888" },
                    { 2, new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), false, "12:30", "11:00", "Roberta", 3, "911113333" },
                    { 3, new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), false, "10:00", "08:20", "Carla", 2, "977776666" }
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Cidade", "Estado", "Numero", "Pais", "Rua", "SalaoId" },
                values: new object[,]
                {
                    { 1, "Jardim da Penha", "29000000", "Vitória", "Espírito Santo", "SN", null, "Clotilde", 1 },
                    { 2, "Cordoado", "29555000", "Guarapari", "Espírito Santo", "22", null, "America", 2 },
                    { 3, "Laranjeiras", "29888000", "Serra", "Espírito Santo", "1", null, "Copacabana", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_SalaoId",
                table: "Agendas",
                column: "SalaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_SalaoId",
                table: "Enderecos",
                column: "SalaoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Saloes");
        }
    }
}

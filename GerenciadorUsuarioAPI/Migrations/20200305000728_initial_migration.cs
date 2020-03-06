using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorUsuarioAPI.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfils",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfils", x => x.IdPerfil);
                });

            migrationBuilder.CreateTable(
                name: "Funcionalidades",
                columns: table => new
                {
                    IdFuncionalidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    IdPerfil = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    PerfilIdPerfil = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionalidades", x => x.IdFuncionalidade);
                    table.ForeignKey(
                        name: "FK_Funcionalidades_Perfils_PerfilIdPerfil",
                        column: x => x.PerfilIdPerfil,
                        principalTable: "Perfils",
                        principalColumn: "IdPerfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Sobrenome = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    IdPerfil = table.Column<int>(nullable: false),
                    PerfilIdPerfil = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfils_PerfilIdPerfil",
                        column: x => x.PerfilIdPerfil,
                        principalTable: "Perfils",
                        principalColumn: "IdPerfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Funcionalidades",
                columns: new[] { "IdFuncionalidade", "DataCadastro", "Descricao", "IdPerfil", "Nome", "PerfilIdPerfil" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(1980), "Possibilita Adição de novos Usuários", 2, "AdicionarUsuario", null },
                    { 2, new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(2905), "Possibilita Alterar dados dos Usuários", 3, "AlterarUsuario", null },
                    { 3, new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(2938), "Possibilita Remoção de Usuários", 2, "RemoverUsuario", null },
                    { 4, new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(2942), "Possibilita acesso ao sistema", 1, "AcessoBasico", null }
                });

            migrationBuilder.InsertData(
                table: "Perfils",
                columns: new[] { "IdPerfil", "DataCadastro", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 4, 21, 7, 27, 790, DateTimeKind.Local).AddTicks(9704), "Adiciona Novos Perfis, Gerencia Funcionalidades e Usuários", "Administrador" },
                    { 2, new DateTime(2020, 3, 4, 21, 7, 27, 793, DateTimeKind.Local).AddTicks(1484), "Adiciona Novos Usuários e remove", "Gerente" },
                    { 3, new DateTime(2020, 3, 4, 21, 7, 27, 793, DateTimeKind.Local).AddTicks(1535), "Possui acesso ao gerenciador", "Membro" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "DataCadastro", "DataNascimento", "IdPerfil", "Nome", "PerfilIdPerfil", "Sobrenome" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(7692), new DateTime(1951, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Jane", null, "Smith" },
                    { 2, new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8783), new DateTime(1982, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "John", null, "Fisher" },
                    { 3, new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8824), new DateTime(1996, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Pamela", null, "Baker" },
                    { 4, new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8831), new DateTime(1986, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Emmanuel", null, "Porto" },
                    { 5, new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8837), new DateTime(1967, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Peter", null, "Taylor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionalidades_PerfilIdPerfil",
                table: "Funcionalidades",
                column: "PerfilIdPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PerfilIdPerfil",
                table: "Usuarios",
                column: "PerfilIdPerfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionalidades");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Perfils");
        }
    }
}

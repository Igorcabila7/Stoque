using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Stock.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    produtoFotografia = table.Column<string>(type: "text", nullable: false),
                    produtonome = table.Column<string>(type: "text", nullable: false),
                    categoria = table.Column<string>(type: "text", nullable: false),
                    tipo = table.Column<string>(type: "text", nullable: false),
                    preco = table.Column<float>(type: "real", nullable: false),
                    quantidade = table.Column<float>(type: "real", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserFotografiaPath = table.Column<string>(type: "text", nullable: false),
                    UserNomeCompleto = table.Column<string>(type: "text", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: false),
                    UserIdade = table.Column<int>(type: "integer", nullable: false),
                    UserSector = table.Column<string>(type: "text", nullable: false),
                    UserNacionalidade = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movimentostocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movimento = table.Column<string>(type: "text", nullable: false),
                    dateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    produtoid = table.Column<int>(type: "integer", nullable: false),
                    MovimentostockId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimentostocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movimentostocks_movimentostocks_MovimentostockId",
                        column: x => x.MovimentostockId,
                        principalTable: "movimentostocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movimentostocks_produto_produtoid",
                        column: x => x.produtoid,
                        principalTable: "produto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usercodigopais = table.Column<string>(type: "text", nullable: false),
                    usertelefone1 = table.Column<string>(type: "text", nullable: false),
                    usertelefone2 = table.Column<string>(type: "text", nullable: false),
                    usertelefonefixo = table.Column<string>(type: "text", nullable: false),
                    usuarioid = table.Column<int>(type: "integer", nullable: false),
                    contactosid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contactos_Contactos_contactosid",
                        column: x => x.contactosid,
                        principalTable: "Contactos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contactos_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Localizacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userpais = table.Column<string>(type: "text", nullable: false),
                    userprovincia = table.Column<string>(type: "text", nullable: false),
                    usercomuna = table.Column<string>(type: "text", nullable: false),
                    userbairro = table.Column<string>(type: "text", nullable: false),
                    usernumerocasa = table.Column<string>(type: "text", nullable: false),
                    usuarioid = table.Column<int>(type: "integer", nullable: false),
                    localizacaoid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacao", x => x.id);
                    table.ForeignKey(
                        name: "FK_Localizacao_Localizacao_localizacaoid",
                        column: x => x.localizacaoid,
                        principalTable: "Localizacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Localizacao_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_contactosid",
                table: "Contactos",
                column: "contactosid");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_usuarioid",
                table: "Contactos",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Localizacao_localizacaoid",
                table: "Localizacao",
                column: "localizacaoid");

            migrationBuilder.CreateIndex(
                name: "IX_Localizacao_usuarioid",
                table: "Localizacao",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_movimentostocks_MovimentostockId",
                table: "movimentostocks",
                column: "MovimentostockId");

            migrationBuilder.CreateIndex(
                name: "IX_movimentostocks_produtoid",
                table: "movimentostocks",
                column: "produtoid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Localizacao");

            migrationBuilder.DropTable(
                name: "movimentostocks");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "produto");
        }
    }
}

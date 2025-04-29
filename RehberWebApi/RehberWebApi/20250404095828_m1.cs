using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RehberWebApi.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rehbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Soyad = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Firma = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rehbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "İletisimBilgileris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    TelefonNumarası = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Email = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Adres = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Konum = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    RehberId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletisimBilgileris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_İletisimBilgileris_Rehbers_~",
                        column: x => x.RehberId,
                        principalTable: "Rehbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_İletisimBilgileris_RehberId",
                table: "İletisimBilgileris",
                column: "RehberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "İletisimBilgileris");

            migrationBuilder.DropTable(
                name: "Rehbers");
        }
    }
}

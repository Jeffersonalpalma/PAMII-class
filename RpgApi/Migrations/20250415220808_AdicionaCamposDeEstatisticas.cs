using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaCamposDeEstatisticas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADE_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_HABILIDADE",
                table: "TB_HABILIDADE");

            migrationBuilder.RenameTable(
                name: "TB_HABILIDADE",
                newName: "TB_HABILIDADES");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_HABILIDADES",
                table: "TB_HABILIDADES",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 228, 58, 204, 105, 237, 30, 52, 36, 147, 45, 245, 50, 185, 212, 122, 117, 219, 253, 130, 168, 227, 68, 106, 55, 23, 88, 87, 35, 217, 190, 69, 128, 56, 247, 4, 111, 217, 91, 16, 157, 199, 106, 163, 68, 153, 164, 239, 100, 1, 70, 181, 241, 26, 18, 171, 81, 135, 208, 34, 101, 206, 82, 210 }, new byte[] { 27, 192, 36, 76, 236, 45, 60, 246, 55, 146, 52, 102, 176, 118, 81, 67, 57, 73, 4, 58, 125, 49, 197, 146, 147, 15, 62, 161, 132, 163, 25, 137, 114, 251, 95, 181, 171, 232, 36, 198, 2, 114, 185, 36, 19, 246, 105, 1, 9, 155, 213, 130, 136, 22, 98, 88, 57, 0, 73, 162, 141, 8, 209, 102, 91, 99, 144, 32, 247, 166, 212, 183, 228, 68, 131, 25, 88, 27, 243, 141, 73, 189, 244, 93, 211, 116, 57, 86, 94, 72, 101, 107, 204, 70, 61, 115, 19, 128, 33, 230, 22, 74, 20, 88, 17, 197, 129, 101, 123, 191, 184, 196, 93, 89, 61, 150, 245, 111, 251, 72, 177, 237, 212, 150, 91, 77, 74, 208 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId",
                principalTable: "TB_HABILIDADES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_HABILIDADES",
                table: "TB_HABILIDADES");

            migrationBuilder.RenameTable(
                name: "TB_HABILIDADES",
                newName: "TB_HABILIDADE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_HABILIDADE",
                table: "TB_HABILIDADE",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 120, 176, 176, 31, 234, 32, 253, 107, 54, 99, 158, 50, 93, 94, 0, 49, 124, 79, 251, 83, 232, 115, 185, 46, 54, 50, 92, 112, 60, 189, 202, 114, 186, 23, 139, 136, 107, 11, 37, 171, 51, 150, 137, 1, 123, 173, 192, 133, 118, 222, 79, 43, 170, 160, 24, 211, 19, 186, 139, 202, 117, 251, 163 }, new byte[] { 76, 77, 150, 144, 116, 80, 116, 61, 108, 204, 100, 229, 29, 240, 9, 149, 247, 27, 185, 68, 218, 113, 225, 47, 24, 14, 55, 160, 140, 33, 238, 112, 33, 210, 33, 230, 96, 10, 56, 225, 174, 31, 58, 190, 210, 70, 43, 89, 227, 22, 96, 3, 160, 199, 69, 235, 74, 109, 29, 254, 220, 124, 100, 115, 176, 208, 126, 76, 147, 72, 69, 121, 51, 149, 170, 102, 155, 162, 57, 255, 186, 238, 80, 62, 96, 206, 116, 21, 20, 243, 207, 190, 249, 240, 189, 226, 152, 38, 113, 29, 227, 146, 26, 178, 20, 250, 196, 226, 134, 51, 111, 246, 96, 98, 216, 230, 111, 240, 45, 0, 38, 162, 11, 177, 144, 28, 17, 52 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADE_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId",
                principalTable: "TB_HABILIDADE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

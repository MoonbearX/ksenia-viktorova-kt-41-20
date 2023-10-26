using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KseniaViktorovaKt_41_20.Migrations
{
    /// <inheritdoc />
    public partial class upd_db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "student_phone",
                table: "student",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                comment: "Номер телефона студента",
                oldClrType: typeof(string),
                oldType: "varchar(18)",
                oldMaxLength: 18,
                oldComment: "Номер телефона студента");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "student_phone",
                table: "student",
                type: "varchar(18)",
                maxLength: 18,
                nullable: false,
                comment: "Номер телефона студента",
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16,
                oldComment: "Номер телефона студента");
        }
    }
}

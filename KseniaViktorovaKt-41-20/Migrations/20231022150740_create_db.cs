using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KseniaViktorovaKt_41_20.Migrations
{
    /// <inheritdoc />
    public partial class create_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    id_group = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор студента")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, comment: "Название группы")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_(TAbleName)_id_group", x => x.id_group);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор студента")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_group = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор группы"),
                    student_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, comment: "Имя студента"),
                    student_surname = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, comment: "Фамилия студента"),
                    student_patronymic = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, comment: "Отчество студента")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_student_student_id", x => x.student_id);
                    table.ForeignKey(
                        name: "fk_group_id",
                        column: x => x.id_group,
                        principalTable: "Groups",
                        principalColumn: "id_group",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_student_fk_group_id",
                table: "student",
                column: "id_group");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}

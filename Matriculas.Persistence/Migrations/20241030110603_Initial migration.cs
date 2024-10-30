using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Matriculas.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Alumnos",
                columns: table => new
                {
                    nIdAlumno = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Alumnos", x => x.nIdAlumno);
                });

            migrationBuilder.CreateTable(
                name: "tb_Aulas",
                columns: table => new
                {
                    nIdAula = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nCapacidad = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Aulas", x => x.nIdAula);
                });

            migrationBuilder.CreateTable(
                name: "tb_Secciones",
                columns: table => new
                {
                    nIdSeccion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nIdAula = table.Column<long>(type: "bigint", nullable: false),
                    sTurno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tHoraInicio = table.Column<TimeOnly>(type: "time", nullable: false),
                    tHoraFin = table.Column<TimeOnly>(type: "time", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Secciones", x => x.nIdSeccion);
                    table.ForeignKey(
                        name: "FK_tb_Secciones_tb_Aulas_nIdAula",
                        column: x => x.nIdAula,
                        principalTable: "tb_Aulas",
                        principalColumn: "nIdAula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cursos",
                columns: table => new
                {
                    nIdCurso = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sDesCurso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nIdSeccion = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cursos", x => x.nIdCurso);
                    table.ForeignKey(
                        name: "FK_tb_Cursos_tb_Secciones_nIdSeccion",
                        column: x => x.nIdSeccion,
                        principalTable: "tb_Secciones",
                        principalColumn: "nIdSeccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Matricula",
                columns: table => new
                {
                    nIdRegistro = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nIdAlumno = table.Column<long>(type: "bigint", nullable: false),
                    nIdSeccion = table.Column<long>(type: "bigint", nullable: false),
                    IdCurso = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Matricula", x => x.nIdRegistro);
                    table.ForeignKey(
                        name: "FK_tb_Matricula_tb_Alumnos_nIdAlumno",
                        column: x => x.nIdAlumno,
                        principalTable: "tb_Alumnos",
                        principalColumn: "nIdAlumno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Matricula_tb_Secciones_nIdSeccion",
                        column: x => x.nIdSeccion,
                        principalTable: "tb_Secciones",
                        principalColumn: "nIdSeccion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tb_Alumnos",
                columns: new[] { "nIdAlumno", "CreateDate", "DeleteDate", "IsActive", "sNombre", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(6446), null, true, "Alumno 1", null },
                    { 2L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(6475), null, true, "Alumno 2", null },
                    { 3L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(6476), null, true, "Alumno 3", null },
                    { 4L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(6478), null, true, "Alumno 4", null },
                    { 5L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(6481), null, true, "Alumno 5", null }
                });

            migrationBuilder.InsertData(
                table: "tb_Aulas",
                columns: new[] { "nIdAula", "nCapacidad", "CreateDate", "DeleteDate", "IsActive", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, 2, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(8392), null, true, null },
                    { 2L, 2, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(8396), null, true, null }
                });

            migrationBuilder.InsertData(
                table: "tb_Secciones",
                columns: new[] { "nIdSeccion", "CreateDate", "DeleteDate", "tHoraFin", "tHoraInicio", "nIdAula", "IsActive", "sTurno", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 10, 30, 6, 6, 2, 882, DateTimeKind.Local).AddTicks(1078), null, new TimeOnly(10, 0, 0), new TimeOnly(8, 0, 0), 1L, true, "Mañana", null },
                    { 2L, new DateTime(2024, 10, 30, 6, 6, 2, 882, DateTimeKind.Local).AddTicks(1085), null, new TimeOnly(16, 0, 0), new TimeOnly(14, 0, 0), 1L, true, "Tarde", null },
                    { 3L, new DateTime(2024, 10, 30, 6, 6, 2, 882, DateTimeKind.Local).AddTicks(1087), null, new TimeOnly(22, 0, 0), new TimeOnly(20, 0, 0), 2L, true, "Noche", null }
                });

            migrationBuilder.InsertData(
                table: "tb_Cursos",
                columns: new[] { "nIdCurso", "CreateDate", "DeleteDate", "sDesCurso", "nIdSeccion", "IsActive", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(9682), null, "Curso de prueba 1", 1L, true, null },
                    { 2L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(9687), null, "Curso de prueba 2", 1L, true, null },
                    { 3L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(9688), null, "Curso de prueba 3", 2L, true, null },
                    { 4L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(9690), null, "Curso de prueba 4", 2L, true, null },
                    { 5L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(9691), null, "Curso de prueba 5", 3L, true, null },
                    { 6L, new DateTime(2024, 10, 30, 6, 6, 2, 881, DateTimeKind.Local).AddTicks(9692), null, "Curso de prueba 6", 3L, true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cursos_nIdSeccion",
                table: "tb_Cursos",
                column: "nIdSeccion");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Matricula_nIdAlumno",
                table: "tb_Matricula",
                column: "nIdAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Matricula_nIdSeccion",
                table: "tb_Matricula",
                column: "nIdSeccion");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Secciones_nIdAula",
                table: "tb_Secciones",
                column: "nIdAula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Cursos");

            migrationBuilder.DropTable(
                name: "tb_Matricula");

            migrationBuilder.DropTable(
                name: "tb_Alumnos");

            migrationBuilder.DropTable(
                name: "tb_Secciones");

            migrationBuilder.DropTable(
                name: "tb_Aulas");
        }
    }
}

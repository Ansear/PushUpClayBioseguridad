using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "categoriaper",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         nombreCategoria = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "estado",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "pais",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         NombrePais = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "tipocontacto",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "tipodireccion",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "tipopersona",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "turnos",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         nombreTurno = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         horaTurnoInicio = table.Column<TimeOnly>(type: "time", nullable: true),
            //         horaTurnoFin = table.Column<TimeOnly>(type: "time", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "contrato",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         fechacontrato = table.Column<DateOnly>(type: "date", nullable: true),
            //         FechaFin = table.Column<DateOnly>(type: "date", nullable: true),
            //         IdEstado = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "contrato_ibfk_1",
            //             column: x => x.IdEstado,
            //             principalTable: "estado",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "departamento",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         nombreDep = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdPais = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "departamento_ibfk_1",
            //             column: x => x.IdPais,
            //             principalTable: "pais",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "ciudad",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         nombreciud = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdDep = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "ciudad_ibfk_1",
            //             column: x => x.IdDep,
            //             principalTable: "departamento",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "persona",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         IdPersona = table.Column<string>(type: "varchar(255)", nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         nombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         FechaRegistro = table.Column<DateOnly>(type: "date", nullable: true),
            //         IdTipoPersona = table.Column<int>(type: "int", nullable: true),
            //         IdCategoria = table.Column<int>(type: "int", nullable: true),
            //         IdCiudad = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "persona_ibfk_1",
            //             column: x => x.IdTipoPersona,
            //             principalTable: "tipopersona",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "persona_ibfk_2",
            //             column: x => x.IdCategoria,
            //             principalTable: "categoriaper",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "persona_ibfk_3",
            //             column: x => x.IdCiudad,
            //             principalTable: "ciudad",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "contactoper",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         IdPersona = table.Column<int>(type: "int", nullable: true),
            //         IdTipoContacto = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "contactoper_ibfk_1",
            //             column: x => x.IdPersona,
            //             principalTable: "persona",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "contactoper_ibfk_2",
            //             column: x => x.IdTipoContacto,
            //             principalTable: "tipocontacto",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "dirpersona",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdPersona = table.Column<int>(type: "int", nullable: true),
            //         IdTipoDireccion = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "dirpersona_ibfk_1",
            //             column: x => x.IdPersona,
            //             principalTable: "persona",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "dirpersona_ibfk_2",
            //             column: x => x.IdTipoDireccion,
            //             principalTable: "tipodireccion",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateTable(
            //     name: "programacion",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false),
            //         IdContrato = table.Column<int>(type: "int", nullable: true),
            //         IdTurno = table.Column<int>(type: "int", nullable: true),
            //         IdEmpleado = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "programacion_ibfk_1",
            //             column: x => x.IdContrato,
            //             principalTable: "contrato",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "programacion_ibfk_2",
            //             column: x => x.IdTurno,
            //             principalTable: "turnos",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "programacion_ibfk_3",
            //             column: x => x.IdEmpleado,
            //             principalTable: "persona",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4")
            //     .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            // migrationBuilder.CreateIndex(
            //     name: "IdDep",
            //     table: "ciudad",
            //     column: "IdDep");

            // migrationBuilder.CreateIndex(
            //     name: "IdPersona",
            //     table: "contactoper",
            //     column: "IdPersona");

            // migrationBuilder.CreateIndex(
            //     name: "IdTipoContacto",
            //     table: "contactoper",
            //     column: "IdTipoContacto");

            // migrationBuilder.CreateIndex(
            //     name: "IdEstado",
            //     table: "contrato",
            //     column: "IdEstado");

            // migrationBuilder.CreateIndex(
            //     name: "IdPais",
            //     table: "departamento",
            //     column: "IdPais");

            // migrationBuilder.CreateIndex(
            //     name: "IdPersona1",
            //     table: "dirpersona",
            //     column: "IdPersona");

            // migrationBuilder.CreateIndex(
            //     name: "IdTipoDireccion",
            //     table: "dirpersona",
            //     column: "IdTipoDireccion");

            // migrationBuilder.CreateIndex(
            //     name: "IdCategoria",
            //     table: "persona",
            //     column: "IdCategoria");

            // migrationBuilder.CreateIndex(
            //     name: "IdCiudad",
            //     table: "persona",
            //     column: "IdCiudad");

            // migrationBuilder.CreateIndex(
            //     name: "IdPersona2",
            //     table: "persona",
            //     column: "IdPersona",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IdTipoPersona",
            //     table: "persona",
            //     column: "IdTipoPersona");

            // migrationBuilder.CreateIndex(
            //     name: "IdContrato",
            //     table: "programacion",
            //     column: "IdContrato");

            // migrationBuilder.CreateIndex(
            //     name: "IdEmpleado",
            //     table: "programacion",
            //     column: "IdEmpleado");

            // migrationBuilder.CreateIndex(
            //     name: "IdTurno",
            //     table: "programacion",
            //     column: "IdTurno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "contactoper");

            // migrationBuilder.DropTable(
            //     name: "dirpersona");

            // migrationBuilder.DropTable(
            //     name: "programacion");

            // migrationBuilder.DropTable(
            //     name: "tipocontacto");

            // migrationBuilder.DropTable(
            //     name: "tipodireccion");

            // migrationBuilder.DropTable(
            //     name: "contrato");

            // migrationBuilder.DropTable(
            //     name: "turnos");

            // migrationBuilder.DropTable(
            //     name: "persona");

            // migrationBuilder.DropTable(
            //     name: "estado");

            // migrationBuilder.DropTable(
            //     name: "tipopersona");

            // migrationBuilder.DropTable(
            //     name: "categoriaper");

            // migrationBuilder.DropTable(
            //     name: "ciudad");

            // migrationBuilder.DropTable(
            //     name: "departamento");

            // migrationBuilder.DropTable(
            //     name: "pais");
        }
    }
}

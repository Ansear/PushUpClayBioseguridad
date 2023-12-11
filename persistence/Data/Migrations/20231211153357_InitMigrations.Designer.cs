﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using persistence.Data;

#nullable disable

namespace persistence.Data.Migrations
{
    [DbContext(typeof(PushUpContext))]
    [Migration("20231211153357_InitMigrations")]
    partial class InitMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("persistence.Entities.Categoriaper", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NombreCategoria")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombreCategoria");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("categoriaper", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdDep")
                        .HasColumnType("int");

                    b.Property<string>("Nombreciud")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombreciud");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdDep" }, "IdDep");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Contactoper", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoContacto")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPersona" }, "IdPersona");

                    b.HasIndex(new[] { "IdTipoContacto" }, "IdTipoContacto");

                    b.ToTable("contactoper", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("Fechacontrato")
                        .HasColumnType("date")
                        .HasColumnName("fechacontrato");

                    b.Property<int?>("IdEstado")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEstado" }, "IdEstado");

                    b.ToTable("contrato", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdPais")
                        .HasColumnType("int");

                    b.Property<string>("NombreDep")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombreDep");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPais" }, "IdPais");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Dirpersona", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("direccion");

                    b.Property<int?>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoDireccion")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPersona" }, "IdPersona")
                        .HasDatabaseName("IdPersona1");

                    b.HasIndex(new[] { "IdTipoDireccion" }, "IdTipoDireccion");

                    b.ToTable("dirpersona", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdCiudad")
                        .HasColumnType("int");

                    b.Property<string>("IdPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("IdTipoPersona")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCategoria" }, "IdCategoria");

                    b.HasIndex(new[] { "IdCiudad" }, "IdCiudad");

                    b.HasIndex(new[] { "IdPersona" }, "IdPersona")
                        .IsUnique()
                        .HasDatabaseName("IdPersona2");

                    b.HasIndex(new[] { "IdTipoPersona" }, "IdTipoPersona");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Programacion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdContrato")
                        .HasColumnType("int");

                    b.Property<int?>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int?>("IdTurno")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdContrato" }, "IdContrato");

                    b.HasIndex(new[] { "IdEmpleado" }, "IdEmpleado");

                    b.HasIndex(new[] { "IdTurno" }, "IdTurno");

                    b.ToTable("programacion", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Tipocontacto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipocontacto", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Tipodireccion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipodireccion", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Tipopersona", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipopersona", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Turno", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("HoraTurnoFin")
                        .HasColumnType("time")
                        .HasColumnName("horaTurnoFin");

                    b.Property<TimeOnly?>("HoraTurnoInicio")
                        .HasColumnType("time")
                        .HasColumnName("horaTurnoInicio");

                    b.Property<string>("NombreTurno")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombreTurno");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("turnos", (string)null);
                });

            modelBuilder.Entity("persistence.Entities.Ciudad", b =>
                {
                    b.HasOne("persistence.Entities.Departamento", "IdDepNavigation")
                        .WithMany("Ciudads")
                        .HasForeignKey("IdDep")
                        .HasConstraintName("ciudad_ibfk_1");

                    b.Navigation("IdDepNavigation");
                });

            modelBuilder.Entity("persistence.Entities.Contactoper", b =>
                {
                    b.HasOne("persistence.Entities.Persona", "IdPersonaNavigation")
                        .WithMany("Contactopers")
                        .HasForeignKey("IdPersona")
                        .HasConstraintName("contactoper_ibfk_1");

                    b.HasOne("persistence.Entities.Tipocontacto", "IdTipoContactoNavigation")
                        .WithMany("Contactopers")
                        .HasForeignKey("IdTipoContacto")
                        .HasConstraintName("contactoper_ibfk_2");

                    b.Navigation("IdPersonaNavigation");

                    b.Navigation("IdTipoContactoNavigation");
                });

            modelBuilder.Entity("persistence.Entities.Contrato", b =>
                {
                    b.HasOne("persistence.Entities.Estado", "IdEstadoNavigation")
                        .WithMany("Contratos")
                        .HasForeignKey("IdEstado")
                        .HasConstraintName("contrato_ibfk_1");

                    b.Navigation("IdEstadoNavigation");
                });

            modelBuilder.Entity("persistence.Entities.Departamento", b =>
                {
                    b.HasOne("persistence.Entities.Pais", "IdPaisNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPais")
                        .HasConstraintName("departamento_ibfk_1");

                    b.Navigation("IdPaisNavigation");
                });

            modelBuilder.Entity("persistence.Entities.Dirpersona", b =>
                {
                    b.HasOne("persistence.Entities.Persona", "IdPersonaNavigation")
                        .WithMany("Dirpersonas")
                        .HasForeignKey("IdPersona")
                        .HasConstraintName("dirpersona_ibfk_1");

                    b.HasOne("persistence.Entities.Tipodireccion", "IdTipoDireccionNavigation")
                        .WithMany("Dirpersonas")
                        .HasForeignKey("IdTipoDireccion")
                        .HasConstraintName("dirpersona_ibfk_2");

                    b.Navigation("IdPersonaNavigation");

                    b.Navigation("IdTipoDireccionNavigation");
                });

            modelBuilder.Entity("persistence.Entities.Persona", b =>
                {
                    b.HasOne("persistence.Entities.Categoriaper", "IdCategoriaNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("persona_ibfk_2");

                    b.HasOne("persistence.Entities.Ciudad", "IdCiudadNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudad")
                        .HasConstraintName("persona_ibfk_3");

                    b.HasOne("persistence.Entities.Tipopersona", "IdTipoPersonaNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersona")
                        .HasConstraintName("persona_ibfk_1");

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdCiudadNavigation");

                    b.Navigation("IdTipoPersonaNavigation");
                });

            modelBuilder.Entity("persistence.Entities.Programacion", b =>
                {
                    b.HasOne("persistence.Entities.Contrato", "IdContratoNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdContrato")
                        .HasConstraintName("programacion_ibfk_1");

                    b.HasOne("persistence.Entities.Persona", "IdEmpleadoNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdEmpleado")
                        .HasConstraintName("programacion_ibfk_3");

                    b.HasOne("persistence.Entities.Turno", "IdTurnoNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdTurno")
                        .HasConstraintName("programacion_ibfk_2");

                    b.Navigation("IdContratoNavigation");

                    b.Navigation("IdEmpleadoNavigation");

                    b.Navigation("IdTurnoNavigation");
                });

            modelBuilder.Entity("persistence.Entities.Categoriaper", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("persistence.Entities.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("persistence.Entities.Contrato", b =>
                {
                    b.Navigation("Programacions");
                });

            modelBuilder.Entity("persistence.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudads");
                });

            modelBuilder.Entity("persistence.Entities.Estado", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("persistence.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("persistence.Entities.Persona", b =>
                {
                    b.Navigation("Contactopers");

                    b.Navigation("Dirpersonas");

                    b.Navigation("Programacions");
                });

            modelBuilder.Entity("persistence.Entities.Tipocontacto", b =>
                {
                    b.Navigation("Contactopers");
                });

            modelBuilder.Entity("persistence.Entities.Tipodireccion", b =>
                {
                    b.Navigation("Dirpersonas");
                });

            modelBuilder.Entity("persistence.Entities.Tipopersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("persistence.Entities.Turno", b =>
                {
                    b.Navigation("Programacions");
                });
#pragma warning restore 612, 618
        }
    }
}
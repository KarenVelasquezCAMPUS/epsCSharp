﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(epsContext))]
    partial class epsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Acudiente", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Code");

                    b.ToTable("Acudientes");
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DatosUsuario")
                        .HasColumnType("int");

                    b.Property<int>("EstadoCita")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoCitasId")
                        .HasColumnType("int");

                    b.Property<string>("FullNameMedico")
                        .HasColumnType("longtext");

                    b.Property<string>("IdEstadoCita")
                        .HasColumnType("longtext");

                    b.Property<int>("Medico")
                        .HasColumnType("int");

                    b.Property<int?>("MedicosNroMatriculaProfesional")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumberUsuario")
                        .HasColumnType("longtext");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.HasIndex("EstadoCitasId");

                    b.HasIndex("MedicosNroMatriculaProfesional");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Core.Entities.Consultorio", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Code");

                    b.ToTable("Consultorios");
                });

            modelBuilder.Entity("Core.Entities.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Core.Entities.EstadoCita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("EstadoCitas");
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.Property<int>("NroMatriculaProfesional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Consultorio")
                        .HasColumnType("int");

                    b.Property<int?>("ConsultoriosCode")
                        .HasColumnType("int");

                    b.Property<int>("Especialidad")
                        .HasColumnType("int");

                    b.Property<int?>("EspecialidadesId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("IdConsultorio")
                        .HasColumnType("longtext");

                    b.Property<string>("IdEspecialidad")
                        .HasColumnType("longtext");

                    b.HasKey("NroMatriculaProfesional");

                    b.HasIndex("ConsultoriosCode");

                    b.HasIndex("EspecialidadesId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentos");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Acudiente")
                        .HasColumnType("int");

                    b.Property<int?>("AcudientesCode")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("FullNameAcudiente")
                        .HasColumnType("longtext");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int?>("GenerosId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("NameGenero")
                        .HasColumnType("longtext");

                    b.Property<string>("NameTipoDocumento")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("longtext");

                    b.Property<string>("SecondName")
                        .HasColumnType("longtext");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("TipoDocumentosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcudientesCode");

                    b.HasIndex("GenerosId");

                    b.HasIndex("TipoDocumentosId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.HasOne("Core.Entities.EstadoCita", "EstadoCitas")
                        .WithMany("Citas")
                        .HasForeignKey("EstadoCitasId");

                    b.HasOne("Core.Entities.Medico", "Medicos")
                        .WithMany("Citas")
                        .HasForeignKey("MedicosNroMatriculaProfesional");

                    b.HasOne("Core.Entities.Usuario", "Usuarios")
                        .WithMany("Citas")
                        .HasForeignKey("UsuariosId");

                    b.Navigation("EstadoCitas");

                    b.Navigation("Medicos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.HasOne("Core.Entities.Consultorio", "Consultorios")
                        .WithMany("Medicos")
                        .HasForeignKey("ConsultoriosCode");

                    b.HasOne("Core.Entities.Especialidad", "Especialidades")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadesId");

                    b.Navigation("Consultorios");

                    b.Navigation("Especialidades");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.HasOne("Core.Entities.Acudiente", "Acudientes")
                        .WithMany("Usuarios")
                        .HasForeignKey("AcudientesCode");

                    b.HasOne("Core.Entities.Genero", "Generos")
                        .WithMany("Usuarios")
                        .HasForeignKey("GenerosId");

                    b.HasOne("Core.Entities.TipoDocumento", "TipoDocumentos")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoDocumentosId");

                    b.Navigation("Acudientes");

                    b.Navigation("Generos");

                    b.Navigation("TipoDocumentos");
                });

            modelBuilder.Entity("Core.Entities.Acudiente", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Consultorio", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entities.Especialidad", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entities.EstadoCita", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}

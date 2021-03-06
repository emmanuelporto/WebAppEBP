﻿// <auto-generated />
using System;
using GerenciadorUsuarioAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorUsuarioAPI.Migrations
{
    [DbContext(typeof(GerenciadorUsuarioDbContext))]
    [Migration("20200305000728_initial_migration")]
    partial class initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserLibrary.Funcionalidades", b =>
                {
                    b.Property<int>("IdFuncionalidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PerfilIdPerfil")
                        .HasColumnType("int");

                    b.HasKey("IdFuncionalidade");

                    b.HasIndex("PerfilIdPerfil");

                    b.ToTable("Funcionalidades");

                    b.HasData(
                        new
                        {
                            IdFuncionalidade = 1,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(1980),
                            Descricao = "Possibilita Adição de novos Usuários",
                            IdPerfil = 2,
                            Nome = "AdicionarUsuario"
                        },
                        new
                        {
                            IdFuncionalidade = 2,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(2905),
                            Descricao = "Possibilita Alterar dados dos Usuários",
                            IdPerfil = 3,
                            Nome = "AlterarUsuario"
                        },
                        new
                        {
                            IdFuncionalidade = 3,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(2938),
                            Descricao = "Possibilita Remoção de Usuários",
                            IdPerfil = 2,
                            Nome = "RemoverUsuario"
                        },
                        new
                        {
                            IdFuncionalidade = 4,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 794, DateTimeKind.Local).AddTicks(2942),
                            Descricao = "Possibilita acesso ao sistema",
                            IdPerfil = 1,
                            Nome = "AcessoBasico"
                        });
                });

            modelBuilder.Entity("UserLibrary.Perfil", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPerfil");

                    b.ToTable("Perfils");

                    b.HasData(
                        new
                        {
                            IdPerfil = 1,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 790, DateTimeKind.Local).AddTicks(9704),
                            Descricao = "Adiciona Novos Perfis, Gerencia Funcionalidades e Usuários",
                            Nome = "Administrador"
                        },
                        new
                        {
                            IdPerfil = 2,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 793, DateTimeKind.Local).AddTicks(1484),
                            Descricao = "Adiciona Novos Usuários e remove",
                            Nome = "Gerente"
                        },
                        new
                        {
                            IdPerfil = 3,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 793, DateTimeKind.Local).AddTicks(1535),
                            Descricao = "Possui acesso ao gerenciador",
                            Nome = "Membro"
                        });
                });

            modelBuilder.Entity("UserLibrary.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PerfilIdPerfil")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("PerfilIdPerfil");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(7692),
                            DataNascimento = new DateTime(1951, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdPerfil = 3,
                            Nome = "Jane",
                            Sobrenome = "Smith"
                        },
                        new
                        {
                            IdUsuario = 2,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8783),
                            DataNascimento = new DateTime(1982, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdPerfil = 3,
                            Nome = "John",
                            Sobrenome = "Fisher"
                        },
                        new
                        {
                            IdUsuario = 3,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8824),
                            DataNascimento = new DateTime(1996, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdPerfil = 2,
                            Nome = "Pamela",
                            Sobrenome = "Baker"
                        },
                        new
                        {
                            IdUsuario = 4,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8831),
                            DataNascimento = new DateTime(1986, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdPerfil = 1,
                            Nome = "Emmanuel",
                            Sobrenome = "Porto"
                        },
                        new
                        {
                            IdUsuario = 5,
                            DataCadastro = new DateTime(2020, 3, 4, 21, 7, 27, 795, DateTimeKind.Local).AddTicks(8837),
                            DataNascimento = new DateTime(1967, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdPerfil = 3,
                            Nome = "Peter",
                            Sobrenome = "Taylor"
                        });
                });

            modelBuilder.Entity("UserLibrary.Funcionalidades", b =>
                {
                    b.HasOne("UserLibrary.Perfil", "Perfil")
                        .WithMany("Funcionalidades")
                        .HasForeignKey("PerfilIdPerfil");
                });

            modelBuilder.Entity("UserLibrary.Usuario", b =>
                {
                    b.HasOne("UserLibrary.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilIdPerfil");
                });
#pragma warning restore 612, 618
        }
    }
}

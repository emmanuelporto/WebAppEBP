using Microsoft.EntityFrameworkCore;
using System;
using UserLibrary;

namespace GerenciadorUsuarioAPI
{
    public class GerenciadorUsuarioDbContext : DbContext
    {

        public DbSet<Perfil> Perfils { get; set; }

        public DbSet<Funcionalidades> Funcionalidades { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public GerenciadorUsuarioDbContext(DbContextOptions<GerenciadorUsuarioDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Perfil>().HasData(
                new
                {
                    IdPerfil = 1,
                    Nome = "Administrador",
                    Descricao = "Adiciona Novos Perfis, Gerencia Funcionalidades e Usuários",
                    DataCadastro = DateTime.Now,
                },
                new
                {
                    IdPerfil = 2,
                    Nome = "Gerente",
                    Descricao = "Adiciona Novos Usuários e remove",
                    DataCadastro = DateTime.Now,
                },
                new
                {
                    IdPerfil = 3,
                    Nome = "Membro",
                    Descricao = "Possui acesso ao gerenciador",
                    DataCadastro = DateTime.Now,
                }
              );

            builder.Entity<Funcionalidades>().HasData(
                new
                {
                    IdFuncionalidade = 1,
                    Nome = "AdicionarUsuario",
                    Descricao = "Possibilita Adição de novos Usuários",
                    IdPerfil = 2,
                    DataCadastro = DateTime.Now,
                },
                new
                {
                    IdFuncionalidade = 2,
                    Nome = "AlterarUsuario",
                    Descricao = "Possibilita Alterar dados dos Usuários",
                    IdPerfil = 3,
                    DataCadastro = DateTime.Now,
                },
                new
                {
                    IdFuncionalidade = 3,
                    Nome = "RemoverUsuario",
                    Descricao = "Possibilita Remoção de Usuários",
                    IdPerfil = 2,
                    DataCadastro = DateTime.Now,
                },
                new
                {
                    IdFuncionalidade = 4,
                    Nome = "AcessoBasico",
                    Descricao = "Possibilita acesso ao sistema",
                    IdPerfil = 1,
                    DataCadastro = DateTime.Now,
                }
              );

            builder.Entity<Usuario>().HasData(
                new
                {
                    IdUsuario = 1,
                    Nome = "Jane",
                    Sobrenome = "Smith",
                    DataNascimento = Convert.ToDateTime("1951-01-01"),
                    DataCadastro = DateTime.Now,
                    IdPerfil = 3
                },
                new
                {
                    IdUsuario = 2,
                    Nome = "John",
                    Sobrenome = "Fisher",
                    DataNascimento = Convert.ToDateTime("1982-05-02"),
                    DataCadastro = DateTime.Now,
                    IdPerfil = 3
                },
                new
                {
                    IdUsuario = 3,
                    Nome = "Pamela",
                    Sobrenome = "Baker",
                    DataNascimento = Convert.ToDateTime("1996-06-03"),
                    DataCadastro = DateTime.Now,
                    IdPerfil = 2
                },
                new
                {
                    IdUsuario = 4,
                    Nome = "Emmanuel",
                    Sobrenome = "Porto",
                    DataNascimento = Convert.ToDateTime("1986-05-06"),
                    DataCadastro = DateTime.Now,
                    IdPerfil = 1
                },
                new
                {
                    IdUsuario = 5,
                    Nome = "Peter",
                    Sobrenome = "Taylor",
                    DataNascimento = Convert.ToDateTime("1967-10-30"),
                    DataCadastro = DateTime.Now,
                    IdPerfil = 3
                }
            );

        }

    }
}

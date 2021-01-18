using System;
using HackaCCR_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUsuarios.Context
{

    public class ApplicationContext : DbContext
    {

        public DbSet<Users> Usuario { get; set; }
        public DbSet<AlunoUsuario> UsuarioAluno { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Trilha> Trilha{ get; set; }
        public DbSet<Curso> Curso { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options) { }
        public ApplicationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("BaseDeDados");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(c => c.Id);
        }
    }
}

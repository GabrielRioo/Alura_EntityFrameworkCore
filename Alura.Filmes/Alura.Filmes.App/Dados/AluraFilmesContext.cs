using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Filmes.App.Dados
{
	public class AluraFilmesContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Ator>()
				.ToTable("actor");

			modelBuilder.Entity<Ator>()
				.Property(ator => ator.Id)
				.HasColumnName("actor_id");

			modelBuilder.Entity<Ator>()
				.Property(ator => ator.PrimeiroNome)
				.HasColumnName("first_name")
				.HasColumnType("varchar(45)")
				.IsRequired();

			modelBuilder.Entity<Ator>()
				.Property(ator => ator.UltimoNome)
				.HasColumnName("last_name")
				.HasColumnType("varchar(45)")
				.IsRequired();

			modelBuilder.Entity<Ator>()
				.Property<DateTime>("last_update")
				.HasColumnType("datetime")
				.HasDefaultValueSql("getdate()")
				.IsRequired();

			modelBuilder.Entity<Filme>()
				.ToTable("film");

			modelBuilder.Entity<Filme>()
				.Property(filme => filme.Id)
				.HasColumnName("film_id");

			modelBuilder.Entity<Filme>()
				.Property(filme => filme.Titulo)
				.HasColumnName("title")
				.HasColumnType("varchar(255)")
				.IsRequired();

			modelBuilder.Entity<Filme>()
				.Property(filme => filme.Descricao)
				.HasColumnName("description")
				.HasColumnType("text");

			modelBuilder.Entity<Filme>()
				.Property(filme => filme.Anolancamento)
				.HasColumnName("release_year")
				.HasColumnType("varchar(4)");

			modelBuilder.Entity<Filme>()
				.Property(filme => filme.Duracao)
				.HasColumnName("length");

			modelBuilder.Entity<Filme>()
				.Property<DateTime>("last_update")
				.HasColumnType("datetime")
				.HasDefaultValueSql("getdate()")
				.IsRequired();
		}

		public DbSet<Ator> Atores { get; set; }
		public DbSet<Filme> Filmes { get; set; }
	}
}

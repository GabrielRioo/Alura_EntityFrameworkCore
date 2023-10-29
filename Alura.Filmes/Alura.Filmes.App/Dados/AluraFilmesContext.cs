using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;

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
		}

		public DbSet<Ator> Atores { get; set; }
	}
}

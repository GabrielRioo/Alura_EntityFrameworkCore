using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
	public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
	{
		public void Configure(EntityTypeBuilder<Filme> builder)
		{
			builder
				.ToTable("film");

			builder
				.Property(filme => filme.Id)
				.HasColumnName("film_id");

			builder
				.Property(filme => filme.Titulo)
				.HasColumnName("title")
				.HasColumnType("varchar(255)")
				.IsRequired();

			builder
				.Property(filme => filme.Descricao)
				.HasColumnName("description")
				.HasColumnType("text");

			builder
				.Property(filme => filme.Anolancamento)
				.HasColumnName("release_year")
				.HasColumnType("varchar(4)");

			builder
				.Property(filme => filme.Duracao)
				.HasColumnName("length");

			builder
				.Property<DateTime>("last_update")
				.HasColumnType("datetime")
				.HasDefaultValueSql("getdate()")
				.IsRequired();

			builder.Property<byte>("language_id");
			builder.Property<byte?>("original_language_id");

			builder
				.HasOne(f => f.IdiomaFalado)
				.WithMany(i => i.FilmesFalados)
				.HasForeignKey("language_id");

			builder
				.HasOne(f => f.IdiomaOriginal)
				.WithMany(i => i.FilmesOriginais)
				.HasForeignKey("original_language_id");
				
		}
	}
}

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
	public class AtorConfiguration : IEntityTypeConfiguration<Ator>
	{
		public void Configure(EntityTypeBuilder<Ator> builder)
		{
			builder
				.ToTable("actor");

			builder
				.Property(ator => ator.Id)
				.HasColumnName("actor_id");

			builder
				.Property(ator => ator.PrimeiroNome)
				.HasColumnName("first_name")
				.HasColumnType("varchar(45)")
				.IsRequired();

			builder
				.Property(ator => ator.UltimoNome)
				.HasColumnName("last_name")
				.HasColumnType("varchar(45)")
				.IsRequired();

			builder
				.Property<DateTime>("last_update")
				.HasColumnType("datetime")
				.HasDefaultValueSql("getdate()")
				.IsRequired();
		}
	}
}

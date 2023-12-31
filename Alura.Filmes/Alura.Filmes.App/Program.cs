﻿using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using System.Data.Entity;
using System.Linq;

namespace Alura.Filmes.App
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var contexto = new AluraFilmesContext())
			{
				contexto.LogSQLToConsole();

				var idiomas = contexto.Idiomas
					.Include(i => i.FilmesFalados);

				foreach (var idioma in idiomas)
				{
					System.Console.WriteLine(idioma);
				}

				// foreach (var ator in contexto.Atores)
				// {
				//    System.Console.WriteLine(ator);
				// }

				//foreach (var filme in contexto.Filmes)
				//{
				//	System.Console.WriteLine(filme);
				//}

				// Shadow Properties

				//foreach (var elenco in contexto.Elenco)
				//{
				//	// Obtendo valor das Shadow Properties
				//	var entidade = contexto.Entry(elenco);
				//	var filmId = entidade.Property("film_id").CurrentValue;
				//	var actorId = entidade.Property("actor_id").CurrentValue;

				//	System.Console.WriteLine($"Filme: {filmId}, Actor: {actorId}");
				//}
			}

			System.Console.Read();
		}
	}
}
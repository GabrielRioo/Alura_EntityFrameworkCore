using Alura.Filmes.App.Dados;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContext())
            {
                foreach (var ator in contexto.Atores)
                {
                    System.Console.WriteLine(ator);
                }

				foreach (var filme in contexto.Filmes)
				{
					System.Console.WriteLine(filme);
				}
			}
        }
    }
}
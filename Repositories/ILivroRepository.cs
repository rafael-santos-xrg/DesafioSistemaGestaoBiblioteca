using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    public interface ILivroRepository : IItemBibliotecaRepository<Livro>
    {
        Livro? TentaBuscarPorIsbn(Isbn isbn);
        IList<Livro> BuscaPorAutor(string autor);
        IList<Livro> BuscaPorEditora(string editora);

    }
}

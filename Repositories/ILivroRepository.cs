using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    internal interface ILivroRepository : IItemBibliotecaRepository<Livro>
    {
        Livro BuscaPorIsbn(Isbn isbn);
        IList<Livro> BuscaPorAutor(string autor);
        IList<Livro> BuscaPorEditora(string editora);

    }
}

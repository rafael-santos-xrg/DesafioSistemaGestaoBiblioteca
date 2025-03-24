using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    internal interface ILivroRepository : IItemBibliotecaRepository<Livro>
    {
        Livro BuscaPorIsbn(Isbn isbn);
        IEnumerable<Livro> BuscaPorAutor(string autor);
        IEnumerable<Livro> BuscaPorEditora(string editora);

    }
}

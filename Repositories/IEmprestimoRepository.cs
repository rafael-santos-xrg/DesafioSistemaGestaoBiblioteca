using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    internal interface IEmprestimoRepository<T> where T : ItemBibliotecaEmprestavel

    {
    void Adicionar(Emprestimo<T> emprestimo);
    void Remover(Guid emprestimoId);
    List<Emprestimo<T>> BuscarTodos();
    Emprestimo<T> BuscaPorId(Guid emprestimoId);
    }
}

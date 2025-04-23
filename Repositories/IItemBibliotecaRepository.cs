using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    public interface IItemBibliotecaRepository<T> where T : ItemBiblioteca
    {
        void Adicionar(T itemBiblioteca);
        void Atualizar(T itemBiblioteca);
        void Remover(T itemBiblioteca);
        IList<T> BuscarTodos();
        T? TentaBuscarPorId(Guid itemId);
        ItemBiblioteca? TentaBuscarPorCódigo(string codigo);
    }
}

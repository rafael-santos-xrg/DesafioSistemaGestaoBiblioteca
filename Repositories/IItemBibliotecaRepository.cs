using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    internal interface IItemBibliotecaRepository<T> where T : ItemBiblioteca
    {
        void Adicionar(T itemBiblioteca);
        void Atualizar(T itemBiblioteca);
        void Remover(T itemBiblioteca);
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(Guid itemId);

    }
}

using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Services
{
    internal interface IEmprestimoItemService<T> where T : ItemBibliotecaEmprestavel
    {
        Emprestimo<T> Empresta(T idItem, Visitante visitante);

        void Devolve(Guid idEmprestimo);
    }
}

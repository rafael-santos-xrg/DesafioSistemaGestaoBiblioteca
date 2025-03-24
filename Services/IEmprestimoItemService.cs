using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Services
{
    internal interface IEmprestimoItemService
    {
        Emprestimo Empresta(Guid idItem, Visitante visitante);

        void Devolve(Guid idEmprestimo);
    }
}

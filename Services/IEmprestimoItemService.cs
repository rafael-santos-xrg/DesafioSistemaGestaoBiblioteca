using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Services
{
    internal interface IEmprestimoItemService<in T>
    {
        Emprestimo<Livro> Empresta(T idItem, Visitante visitante);

        void Devolve(Guid idEmprestimo);
    }
}

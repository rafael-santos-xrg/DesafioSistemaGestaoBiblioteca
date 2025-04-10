using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Services
{
    internal class EmprestimoLivroService : IEmprestimoItemService<Isbn>
    {
        public Emprestimo<Livro> Empresta(Isbn isbn, Visitante visitante)
        {
            
            throw new NotImplementedException();
        }

        public void Devolve(Guid idEmprestimo)
        {
            throw new NotImplementedException();
        }
    }
}

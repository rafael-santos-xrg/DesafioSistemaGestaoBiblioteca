using System.Collections;
using DesafioSistemaGestaoBiblioteca.Models;
using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    internal class EmprestimoRepository<T> : IEmprestimoRepository<T>, IEnumerable<Emprestimo<T>> where T : ItemBiblioteca
    {
    private List<Emprestimo<T>> _emprestimoList = [];

    public void Adicionar(Emprestimo<T> emprestimo)
    {
        Guarda.RegrasList.ContraItemsIguais(_emprestimoList, emprestimo, nameof(emprestimo));
        _emprestimoList.Add(emprestimo);
    }

    public void Remover(Guid emprestimoId)
    {
        var emprestimoAlvo = _emprestimoList.FirstOrDefault(emprestimo => emprestimo.IdEmprestimo == emprestimoId);
        Guarda.RegrasGeral.ContraNulos(emprestimoAlvo, nameof(emprestimoAlvo));
        _emprestimoList.Remove(emprestimoAlvo!);
    }

    public Emprestimo<T> BuscaPorId(Guid emprestimoId)
    {
        var emprestimoAlvo = _emprestimoList.FirstOrDefault(emprestimo => emprestimo.IdEmprestimo == emprestimoId);
        Guarda.RegrasGeral.ContraNulos(emprestimoAlvo, nameof(emprestimoAlvo));
        return emprestimoAlvo!;
    }

    public List<Emprestimo<T>> BuscarTodos()
    {
        return _emprestimoList;
    }
    public IEnumerator<Emprestimo<T>> GetEnumerator()
    {
        return _emprestimoList.GetEnumerator();
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    }
}

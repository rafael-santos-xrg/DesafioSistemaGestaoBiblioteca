using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Models;

public class Emprestimo<T> where T : ItemBiblioteca
{
    public Guid IdEmprestimo { get; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataMaximaDevolucao { get; set; }
    public Visitante VisitanteInfo { get; set; }
    public T ItemBiblioteca { get; set; }

    public Emprestimo(Visitante visitante, T item)
    {
        Guarda.RegrasGeral.ContraNulos(visitante, nameof(visitante));
        Guarda.RegrasGeral.ContraNulos(item, nameof(item));
        
        IdEmprestimo = Guid.NewGuid();
        ItemBiblioteca = item;
        VisitanteInfo = visitante;
        DataEmprestimo = DateTime.Now;
        DataMaximaDevolucao = DataEmprestimo.Add(ItemBiblioteca.PrazoEmprestimo);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Emprestimo<T> outroEmprestimo)
        {
            return outroEmprestimo.IdEmprestimo.Equals(IdEmprestimo);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return IdEmprestimo.GetHashCode();
    }
}
namespace DesafioSistemaGestaoBiblioteca.Models;

public class Emprestimo
{
    public Guid IdEmprestimo { get; set; }
    public Guid IdItem { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataMaximaDevolucao { get; set; }
    public Visitante VisitanteInfo { get; set; }

    public Emprestimo()
    {
        
    }
}
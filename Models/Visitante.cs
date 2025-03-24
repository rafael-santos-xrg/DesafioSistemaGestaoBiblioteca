using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Models;

public abstract class Visitante
{
    public Guid IdVisitante { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }

    protected Visitante(string nomeVisitante, string cpfVisitante)
    {
        Guarda.RegrasString.ContraParametrosNulosOuVazios(nomeVisitante, nameof(nomeVisitante));

        Nome = nomeVisitante;
        Cpf = cpfVisitante;
        IdVisitante = Guid.NewGuid();
    }
}
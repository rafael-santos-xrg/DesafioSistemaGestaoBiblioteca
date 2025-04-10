using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Models;

public class Visitante
{
    public Guid IdVisitante { get; set; }
    public string Nome { get; set; }
    public Cpf Cpf { get; set; }

    public Visitante(string nomeVisitante, string cpfVisitante)
    {
        Guarda.RegrasString.ContraParametrosNulosOuVazios(nomeVisitante, nameof(nomeVisitante));

        Nome = nomeVisitante;
        Cpf = new Cpf(cpfVisitante);
        IdVisitante = Guid.NewGuid();
    }
}
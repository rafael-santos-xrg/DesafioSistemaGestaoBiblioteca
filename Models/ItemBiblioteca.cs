namespace DesafioSistemaGestaoBiblioteca.Models;

public abstract class ItemBiblioteca
{
    public Guid IdItem { get; } = Guid.NewGuid();
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Editora { get; set; }
    public int AnoLancamento { get; set; }
    public int Edicao { get; set; }
    public TimeSpan PrazoEmprestimo { get; set; }

    protected abstract TimeSpan CalculaPrazoEmprestimo();
}
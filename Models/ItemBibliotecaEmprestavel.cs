namespace DesafioSistemaGestaoBiblioteca.Models;

public abstract class ItemBibliotecaEmprestavel : ItemBiblioteca
{
    public TimeSpan PrazoEmprestimo { get; set; }

    protected abstract TimeSpan CalculaPrazoEmprestimo();
}
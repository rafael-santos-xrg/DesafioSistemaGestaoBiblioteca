
namespace DesafioSistemaGestaoBiblioteca.Models;

public class Ebook : ItemBiblioteca
{
    protected override TimeSpan CalculaPrazoEmprestimo()
    {
        throw new NotImplementedException();
    }
}
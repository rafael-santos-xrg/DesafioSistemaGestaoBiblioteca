namespace DesafioSistemaGestaoBiblioteca.Models;

public class Isbn
{
    public string IsbnCode { get; }

    public Isbn(string isbnCode)
    {
        if (isbnCode == null) throw new ArgumentException("Código ISBN não pode ser nulo");
        if (isbnCode.Length < 13) throw new ArgumentException("Código ISBN incompleto");
        if (isbnCode.Length > 13) throw new ArgumentException("Código ISBN inválido");

        IsbnCode = isbnCode;
    }

    public override string ToString() => IsbnCode;

    public override bool Equals(object? obj)
    {
        if (obj is Isbn outroIsbn)
        {
            return IsbnCode == outroIsbn.IsbnCode;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return IsbnCode.GetHashCode();
    }
}
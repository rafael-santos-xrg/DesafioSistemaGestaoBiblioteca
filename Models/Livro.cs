using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Models;

public class Livro : ItemBibliotecaEmprestavel
{
    public Isbn Isbn { get; }
    public int Estoque { get; set; }
    public int NumPaginas { get; set; }
     
    public Livro(string titulo, string autor, string editora, int anoLancamento, int edicao, string isbn, int estoque, int numPaginas)
    {
        Guarda.RegrasString.ContraParametrosNulosOuVazios(titulo, nameof(titulo));
        Guarda.RegrasString.ContraParametrosNulosOuVazios(autor, nameof(autor));
        Guarda.RegrasString.ContraParametrosNulosOuVazios(editora, nameof(editora));

        Guarda.RegrasInt.ContraParametrosNaoPositivos(anoLancamento, nameof(anoLancamento));
        Guarda.RegrasInt.ContraParametrosNaoPositivos(edicao, nameof(edicao));
        Guarda.RegrasInt.ContraParametrosNegativos(estoque, nameof(estoque));
        Guarda.RegrasInt.ContraParametrosNaoPositivos(numPaginas, nameof(numPaginas));

        Titulo = titulo;
        Autor = autor;
        Editora = editora;
        AnoLancamento = anoLancamento;
        Edicao = edicao;
        Isbn = new Isbn(isbn);
        Estoque = estoque;
        NumPaginas = numPaginas;
        PrazoEmprestimo = CalculaPrazoEmprestimo();
    }

    protected sealed override TimeSpan CalculaPrazoEmprestimo()
    {
        var numDias = (int)Math.Ceiling((double)NumPaginas / 25) * 2;
        var numDiasTimeSpan = TimeSpan.FromDays(numDias);
        return numDiasTimeSpan;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Livro outroLivro)
        {
            return Isbn.Equals(outroLivro.Isbn);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Isbn.GetHashCode();
    }
}
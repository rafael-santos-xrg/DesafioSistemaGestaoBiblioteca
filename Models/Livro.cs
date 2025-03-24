using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Models;

public class Livro : ItemBiblioteca
{
    public Isbn Isbn { get; }
    public int Estoque { get; set; }

    public Livro(string titulo, string autor, string editora, int anoLancamento, int edicao, Isbn isbn, int estoque)
    {
        Guarda.RegrasString.ContraParametrosNulosOuVazios(titulo, nameof(titulo));
        Guarda.RegrasString.ContraParametrosNulosOuVazios(autor, nameof(autor));
        Guarda.RegrasString.ContraParametrosNulosOuVazios(editora, nameof(editora));

        Guarda.RegrasInt.ContraParametrosNaoPositivos(anoLancamento, nameof(anoLancamento));
        Guarda.RegrasInt.ContraParametrosNaoPositivos(edicao, nameof(edicao));
        Guarda.RegrasInt.ContraParametrosNegativos(estoque, nameof(estoque));

        Titulo = titulo;
        Autor = autor;
        Editora = editora;
        AnoLancamento = anoLancamento;
        Edicao = edicao;
        Isbn = isbn;
        Estoque = estoque;
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
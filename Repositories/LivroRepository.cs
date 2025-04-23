using DesafioSistemaGestaoBiblioteca.Models;
using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Repositories
{
    internal class LivroRepository : ILivroRepository
    {
        private List<Livro> _livroList = [];

        public void Adicionar(Livro livro)
        {
            Guarda.RegrasList.ContraItemsIguais(_livroList, livro, livro.Titulo);
            _livroList.Add(livro);
        }

        public void Atualizar(Livro livro)
        {
            Guarda.RegrasList.ContraItemsNaoIguais(_livroList, livro, livro.Titulo);
            var livroAlvoIndex = _livroList.FindIndex(l => l.Isbn.Equals(livro.Isbn));
            _livroList[livroAlvoIndex] = livro;
        }

        public void Remover(Livro livro)
        {
            Guarda.RegrasList.ContraItemsNaoIguais(_livroList, livro, livro.Titulo);
            _livroList.Remove(livro);
        }

        public IList<Livro> BuscaPorAutor(string autor)
        {
            var livrosDoAutor =_livroList.FindAll(l => l.Autor == autor);
            return livrosDoAutor;
        }

        public IList<Livro> BuscaPorEditora(string editora)
        {
            var livrosDaEditora = _livroList.FindAll(l => l.Editora == editora);
            return livrosDaEditora;
        }

        public Livro BuscaPorIsbn(Isbn isbn)
        {
            var livroAlvo = _livroList.Find(l => l.Isbn.Equals(isbn));
            if (livroAlvo == null)
            {
                throw new ArgumentException("Não existe nenhum livro com essa numeração!", isbn.ToString());
            }
            return livroAlvo;
        public Livro? TentaBuscarPorId(Guid itemId)
        {
            return _livroList.FirstOrDefault(l => l.IdItem.Equals(itemId));
        }
        
        public ItemBiblioteca? TentaBuscarPorCódigo(string codigo)
        {
            try
            {
                var isbn = new Isbn(codigo);
                var item = TentaBuscarPorIsbn(isbn);
                return item;
            }
            catch(ArgumentException)
            {
                return null;
            }
        }

        public IList<Livro> BuscarTodos()
        {
            return _livroList;
        }

    }
}

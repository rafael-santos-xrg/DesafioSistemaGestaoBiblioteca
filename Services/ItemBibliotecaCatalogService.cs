using DesafioSistemaGestaoBiblioteca.Models;
using DesafioSistemaGestaoBiblioteca.Repositories;

namespace DesafioSistemaGestaoBiblioteca.Services;

public class ItemBibliotecaCatalogService
{
    private readonly List<IItemBibliotecaRepository<ItemBiblioteca>> _catalogo;

    public ItemBibliotecaCatalogService(params IItemBibliotecaRepository<ItemBiblioteca>[] repositorios)
    {
        _catalogo = repositorios.ToList();
    }

    public ItemBiblioteca? BuscaPorCódigoUnico(string codigoUnico)
    {
        foreach (var repositorio in _catalogo)
        {
            var item = repositorio.TentaBuscarPorCódigo(codigoUnico);
            if (item != null) return item;
        }

        return null;
    }

    public ItemBiblioteca? BuscaPorId(Guid id)
    {
        foreach (var repositorio in _catalogo)
        {
            var item = repositorio.TentaBuscarPorId(id);
            if (item != null) return item;
        }

        return null;
    }

    public List<ItemBiblioteca> BuscaTodos()
    {
        return _catalogo.SelectMany(repositorio => repositorio.BuscarTodos()).ToList();
    }
}
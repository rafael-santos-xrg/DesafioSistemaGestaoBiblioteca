using DesafioSistemaGestaoBiblioteca.Models;

namespace DesafioSistemaGestaoBiblioteca.Services;

public interface IItemBibliotecaCatalogService
{
    ItemBiblioteca? BuscaPorCódigoUnico (string codigoUnico);
    ItemBiblioteca? BuscaPorId (Guid id);
    List<ItemBiblioteca> BuscaTodos();
}
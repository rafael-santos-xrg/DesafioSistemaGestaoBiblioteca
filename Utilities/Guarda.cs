namespace DesafioSistemaGestaoBiblioteca.Utilities;

public class Guarda
{
    public class RegrasString
    {
        public static void ContraParametrosNulosOuVazios(string valor, string nomeParam)
        {
            if (string.IsNullOrEmpty(valor))
                throw new ArgumentException($"{nomeParam} não pode ser nulo ou vazio", nomeParam);
        }
    }

    public class RegrasInt
    {
        public static void ContraParametrosNegativos(int valor, string nomeParam)
        {
            if (int.IsNegative(valor))
                throw new ArgumentException($"{nomeParam} não pode ser menor que zero", nomeParam);
        }

        public static void ContraParametrosNaoPositivos(int valor, string nomeParam)
        {
            if (!int.IsPositive(valor))
                throw new ArgumentException($"{nomeParam} deve ser um número positivo.", nomeParam);
        }
    }
    public class RegrasList
    {
        public static void ContraItemsIguais<T>(List<T> itemList,T item, string nomeItem)
        {
            if (itemList.Contains(item))
                throw new ArgumentException($"O item {nomeItem} já existe na lista", nomeItem);
        }
        public static void ContraItemsNaoIguais<T>(List<T> itemList, T item, string nomeItem)
        {
            if (!itemList.Contains(item))
                throw new ArgumentException($"O item {nomeItem} não existe na lista", nomeItem);
        }
    }
}
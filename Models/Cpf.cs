using DesafioSistemaGestaoBiblioteca.Utilities;

namespace DesafioSistemaGestaoBiblioteca.Models;

public class Cpf
{
    public string CpfValue { get; }

    public Cpf(string cpfValue)
    {
        Guarda.RegrasString.ContraParametrosNulosOuVazios(cpfValue, nameof(cpfValue));
        ValidaFormato(cpfValue);
        ValidaDigitosVerificadores(cpfValue);

        CpfValue = cpfValue;
    }

    private static void ValidaFormato(string cpfValue)
    {
        if (cpfValue.Length != 11 || !cpfValue.All(char.IsDigit))
            throw new Exception("CPF inválido: Deve ser composto por 11 números.");
        if (cpfValue.All(c => c == cpfValue[0]))
            throw new Exception("CPF inválido: Não pode ser composto APENAS por números iguais.");
    }

    private static void ValidaDigitosVerificadores(string cpfValue)
    {
        var primeiroDigitoVerificador = int.Parse(cpfValue.Substring(9, 1));
        var segundoDigitoVerificador = int.Parse(cpfValue.Substring(10, 1));
        var baseComparativaPrimeiroDigito = CalculaBaseComparativaVerificadora(10, cpfValue);
        var baseComparativaSegundoDigito = CalculaBaseComparativaVerificadora(11, cpfValue);
        ComparaDigitoVerificador(primeiroDigitoVerificador, baseComparativaPrimeiroDigito);
        ComparaDigitoVerificador(segundoDigitoVerificador, baseComparativaSegundoDigito);
    }

    private static int CalculaBaseComparativaVerificadora(int fatorInical, string valorBase)
    {
        var somaValoresBaseFatorizados = 0;
        for (int index = 0, fator = fatorInical; fator >= 2; fator--, index++)
        {
            var valorBaseInt = int.Parse(valorBase[index].ToString());
            var valorBaseFatorizado = valorBaseInt * fator;
            somaValoresBaseFatorizados += valorBaseFatorizado;
        }

        return somaValoresBaseFatorizados % 11;
    }

    private static void ComparaDigitoVerificador(int digitoVerificador, int baseComparativa)
    {
        if (baseComparativa < 2 && digitoVerificador != 0)
            throw new Exception("Cpf inválido");
        if (Math.Abs(baseComparativa - 11) != digitoVerificador)
            throw new Exception("CPF Inválido");
    }

    public override bool Equals(object? obj)
    {
        if (obj is Cpf outroCpf)
        {
            return CpfValue == outroCpf.CpfValue;
        }

        return false;
    }

    public override string ToString() => CpfValue;

    public override int GetHashCode() => CpfValue.GetHashCode();
}
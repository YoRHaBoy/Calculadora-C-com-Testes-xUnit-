using Calculadora4;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    public Calculadora construirClasse ()
    {
        string Data = "02/02/2024";
        Calculadora calc = new Calculadora(Data);

        return calc;
    }

    

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int result = calc.Somar(num1, num2);

        Assert.Equal(resultado, result);
    }

    [Theory]
    [InlineData (2, 1, 1)]
    [InlineData (5, 4, 1)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int result = calc.Subtrair(num1, num2);

        Assert.Equal(resultado, result);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int result = calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, result);
    }

    [Theory]
    [InlineData (2, 2, 1)]
    [InlineData (4, 2, 2)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int result = calc.Dividir(num1, num2);

        Assert.Equal(resultado, result);
    }

    [Fact]
    public void DividirPor0()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.Somar(2, 9);
        calc.Somar(6, 3);
        calc.Somar(3, 8);
        calc.Somar(1, 4);

        var lista = calc.Historico();

        Assert.NotEmpty(calc.Historico());
        Assert.Equal(3, lista.Count());
    }

}

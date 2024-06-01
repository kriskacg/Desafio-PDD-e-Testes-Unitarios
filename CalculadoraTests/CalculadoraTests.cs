using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests 
{
    public CalculadoraPrim ConstruirClasse()
    {
        //string data = "31/05/2024";
        CalculadoraPrim calc = new CalculadoraPrim("31/05/2024");
        return calc;
    }

[Theory]
[InlineData (1, 2, 3)]
[InlineData (4, 5, 9)]
public void  TesteSomar(int val1, int val2, int resultado)
{
    CalculadoraPrim calc = ConstruirClasse();

    int resultadoCalculadora = calc.Somar(val1, val2);


    Assert.Equal(resultado, resultadoCalculadora);
}

[Theory]
[InlineData (2, 1, 1)]
[InlineData (7, 5, 2)]
public void  TesteSubtrair(int val1, int val2, int resultado)
{
    CalculadoraPrim calc = ConstruirClasse();

    int resultadoCalculadora = calc.Subtrair(val1, val2);


    Assert.Equal(resultado, resultadoCalculadora);
}

[Theory]
[InlineData (1, 2, 2)]
[InlineData (4, 5, 20)]
public void  TesteMultiplicar(int val1, int val2, int resultado)
{
    CalculadoraPrim calc = ConstruirClasse();

    int resultadoCalculadora = calc.Multiplicar(val1, val2);


    Assert.Equal(resultado, resultadoCalculadora);
}

[Theory]
[InlineData (6, 2, 3)]
[InlineData (10, 5, 2)]
public void  TesteDividir(int val1, int val2, int resultado)
{
    CalculadoraPrim calc = ConstruirClasse();

    int resultadoCalculadora = calc.Dividir(val1, val2);


    Assert.Equal(resultado, resultadoCalculadora);
}

[Fact]
public void TesteDividirPorZero()
{
    CalculadoraPrim calc = ConstruirClasse();

    Assert.Throws<DivideByZeroException> (() => calc.Dividir(3, 0));

}

[Fact]
public void TestarHistorico()
{
    CalculadoraPrim calc = ConstruirClasse();

    calc.Somar(1, 2);
    calc.Somar(2, 2);
    calc.Somar(3, 2);
    calc.Somar(4, 2);

    var lista = calc.historico();
    Assert.NotEmpty(lista);
    Assert.Equal(3, lista.Count());

}





}
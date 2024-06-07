using DESAFIOCALCULADORA.Models;

namespace TesteCalculadora;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2,3) ]
    [InlineData(2,2,4) ]
    public void TesteSomar(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = new CalculadoraSimples();
        int testeSomar = calc.somar(num1,num2);
        Assert.Equal(resultado, testeSomar);
    }

    [Theory]
    [InlineData(1,2,-1) ]
    [InlineData(2,2,0) ]
    public void TesteSubtrair(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = new CalculadoraSimples();
        int testeSubtrair = calc.subtrair(num1,num2);
        Assert.Equal(resultado, testeSubtrair);
    }

    [Theory]
    [InlineData(1,2,2) ]
    [InlineData(2,2,4) ]
    public void TesteMultiplicar(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = new CalculadoraSimples();
        int testeMultiplicar = calc.multiplicar(num1,num2);
        Assert.Equal(resultado, testeMultiplicar);
    }

    [Theory]
    [InlineData(1,2, 0.5) ]
    [InlineData(2,2, 1) ]
    public void TesteDividir(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = new CalculadoraSimples();
        int testeDividir = calc.dividir(num1,num2);
        Assert.Equal(resultado, testeDividir);
    }

    [Fact]
    public void TestarDividaoPorZero(){
        CalculadoraSimples calc = new CalculadoraSimples();
        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }
}

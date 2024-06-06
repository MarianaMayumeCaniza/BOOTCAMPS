using DESAFIOCALCULADORA.Models;

namespace TesteCalculadora;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2,3) ]
    public void Test1(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = new CalculadoraSimples();
        int testeSomar = calc.somar(num1,num2);
        Assert.Equal(resultado, testeSomar);
    }
}
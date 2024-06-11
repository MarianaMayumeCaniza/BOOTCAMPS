using DESAFIOCALCULADORA.Models;

namespace TesteCalculadora;

public class UnitTest1
{
    
    public CalculadoraSimples construirClasse(){
        string data = "02/02/2020";
        //Instância de Historico
        Historico historico = new Historico();

        //Instância de CalculadoraSimples, passando o historico
        CalculadoraSimples calculadora = new CalculadoraSimples(historico, data);

        return calculadora;
    }
    
    [Theory]
    [InlineData(1,2,3) ]
    [InlineData(2,2,4) ]
    public void TesteSomar(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = construirClasse();
        int testeSomar = calc.Somar(num1,num2);
        Assert.Equal(resultado, testeSomar);
    }

    [Theory]
    [InlineData(1,2,-1) ]
    [InlineData(2,2,0) ]
    public void TesteSubtrair(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = construirClasse();
        int testeSubtrair = calc.Subtrair(num1,num2);
        Assert.Equal(resultado, testeSubtrair);
    }

    [Theory]
    [InlineData(1,2,2) ]
    [InlineData(2,2,4) ]
    public void TesteMultiplicar(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = construirClasse();
        int testeMultiplicar = calc.Multiplicar(num1,num2);
        Assert.Equal(resultado, testeMultiplicar);
    }

    [Theory]
    [InlineData(1,2, 0.5) ]
    [InlineData(2,2, 1) ]
    public void TesteDividir(int num1, int num2, int resultado )
    {
        CalculadoraSimples calc = construirClasse();
        int testeDividir = calc.Dividir(num1,num2);
        Assert.Equal(resultado, testeDividir);
    }

    [Fact]
    public void TestarDividaoPorZero(){
        CalculadoraSimples calc = construirClasse();
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico(){
    
        // Cria uma instância de Historico
            Historico historico = new Historico();
            string data = "02/02/2020";

            // Cria uma instância de CalculadoraSimples, passando o historico
            CalculadoraSimples calculadora = new CalculadoraSimples(historico, data);

            // Realiza algumas operações com a calculadora
            calculadora.Somar(1, 1);
            calculadora.Somar(2, 2);
            calculadora.Somar(3, 5);
            calculadora.Somar(4, 5);

            // Obtém o histórico de operações da instância de Historico
            var lista = historico.HistoricoOperacoes;

            // Verifica se o histórico não está vazio e se tem o tamanho esperado
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
    }
}

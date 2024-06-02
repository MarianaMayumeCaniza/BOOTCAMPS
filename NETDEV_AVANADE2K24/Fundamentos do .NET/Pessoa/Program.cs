namespace Pessoa;
using ExemploFundamentos.Common.Models; 

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Pessoa pessoinha = new Pessoa();
        pessoinha.Nome = "Mariana";
        pessoinha.Idade = 27;
        pessoinha.Apresentar();
    }
}

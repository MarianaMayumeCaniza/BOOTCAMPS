using System;
using Calculadora.Models; // Adicione esta linha para importar o namespace correto

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora.Models.Calculadora calculadora = new Calculadora.Models.Calculadora();
            calculadora.Somar(2, 2);
            calculadora.Subtrair(10, 50);
            calculadora.Multiplicar(5, 3);
            calculadora.Dividir(10, 2);
            calculadora.Potencia(3,3);
            calculadora.Seno(30);
            calculadora.Coseno(30);
            calculadora.Tangente(30);
            calculadora.RaizQuadrada(9);


            int numeroIncremento = 10;
            Console.WriteLine("Incrementando o 10");
            Console.WriteLine(numeroIncremento ++);

        }
    }
}

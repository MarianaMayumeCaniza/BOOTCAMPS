using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        //Colocar atributos para a classe pessoa

        //Coloca prop e tab para definir uma propriedade        
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Criar um método
        public void Apresentar(){
            //Console.WriteLine($"Olá, meu nome é {Nome}," +
            // $"e tenho {Idade} anos.");
            //Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos.");
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}
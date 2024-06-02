using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pessoa.Models
{
    public class DadosPessoa
    {
        public DadosPessoa(){

        }
        public DadosPessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome=sobrenome;
        }


        public void Deconstruct(out string nome,  out string sobrenome){
            nome = Nome;
            sobrenome=Sobrenome;
        }
        private string _nome;
        private int _idade;
       public string Nome { 
        get => _nome.ToUpper();
        
        set{
            if (value == ""){
                throw new ArgumentNullException("O nome não pode ser vazio");
            }
            _nome = value;
        } } 

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
       public int Idade { 
        get => _idade; 
        set{
            if(value <0){
                throw new ArgumentException("Idade não pode ser menor que zero");
            }
            _idade = value;

        } 
        }

       public void Apresentar(){
        Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
       }
    }
}
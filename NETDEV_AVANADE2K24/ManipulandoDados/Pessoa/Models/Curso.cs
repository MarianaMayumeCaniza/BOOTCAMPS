using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pessoa.Models;

namespace Pessoa.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<DadosPessoa> Alunos { get; set; }    

        public void AdicionarAluno(DadosPessoa aluno){
            Alunos.Add(aluno);

        }

        public int ObterQuantidadeDeAlunosMatriculados(){

            return Alunos.Count;
        }

        public bool RemoverAluno (DadosPessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAluno(){
            Console.WriteLine($"Alunos do curso de {Nome}");

            for (int count = 0; count < Alunos.Count; count++){
                string texto = "N° " + count+ " "+ Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
                string interpolacao = $"N° {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(interpolacao);
            }
            // foreach (Pessoa aluno in Alunos){
            //     Console.WriteLine(aluno.NomeCompleto)
            // }
        }
    }
}
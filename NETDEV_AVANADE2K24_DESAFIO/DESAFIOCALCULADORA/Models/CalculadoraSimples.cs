using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIOCALCULADORA.Models
{
    public class CalculadoraSimples
    {   
        private Historico _historico;

        public CalculadoraSimples(Historico historico){
            _historico = historico;
        }
        public int somar(int num1, int num2){
            int resultado = num1 + num2;
            _historico.AdicionarOperacao($"Somar: {num1} + {num2} = {resultado}");
            return resultado;
        }

        public int subtrair(int num1, int num2){
             int resultado = num1 - num2;
            _historico.AdicionarOperacao($"Subtrair: {num1} - {num2} = {resultado}");
            return resultado;
        }

        public int multiplicar(int num1, int num2){
              int resultado = num1 * num2;
            _historico.AdicionarOperacao($"Multiplicar: {num1} * {num2} = {resultado}");
            return resultado;
        }

        public int dividir(int num1, int num2){
             int resultado = num1 / num2;
            _historico.AdicionarOperacao($"Dividir: {num1} / {num2} = {resultado}");
            return resultado;
        }

        public List<string> GetHistorico(){
            return _historico.GetHistorico();
        }
    }
}
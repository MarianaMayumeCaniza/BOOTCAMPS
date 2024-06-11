using System;
using System.Collections;

namespace DESAFIOCALCULADORA.Models
{
    public class CalculadoraSimples
    {
        private Historico _historico;
        private string _data;
        public IEnumerable historico;

        public CalculadoraSimples(Historico historico, string data)
        {
            _historico = historico;
            this._data = data;
            
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            _historico.AdicionarOperacao($"Somar: {num1} + {num2} = {resultado} \n  {_data}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            _historico.AdicionarOperacao($"Subtrair: {num1} - {num2} = {resultado} \n  {_data}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            _historico.AdicionarOperacao($"Multiplicar: {num1} * {num2} = {resultado} \n  {_data}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            _historico.AdicionarOperacao($"Dividir: {num1} / {num2} = {resultado} \n  {_data}");
            return resultado;
        }

    }
}

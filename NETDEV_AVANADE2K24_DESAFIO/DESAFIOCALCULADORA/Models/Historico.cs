using System;
using System.Collections.Generic;
using System.Linq;

namespace DESAFIOCALCULADORA.Models
{
    public class Historico
    {
        private List<string> _historico;

        public Historico()
        {
            _historico = new List<string>();
        }

        public void AdicionarOperacao(string operacao)
        {
            _historico.Insert(0,operacao);
        }

        public List<string> HistoricoOperacoes
        {
            get { 
                
                _historico.RemoveRange(3, _historico.Count - 3);   
                return _historico; }
        }

        
    }
}

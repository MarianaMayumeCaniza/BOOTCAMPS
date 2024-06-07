using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DESAFIOCALCULADORA.Models
{
    public class Historico
    {
        private List<string> _historico;

        public Historico(){
            _historico = new List<string>();
        }

        public List<string> GetHistorico(){
            return new List<string>();

        }
        public void AdicionarOperacao(string operacao)
        {
            _historico.Add(operacao);
        }
         public List<string> HistoricoOperacoes
        {
            get { return _historico; }
        }
    }
}
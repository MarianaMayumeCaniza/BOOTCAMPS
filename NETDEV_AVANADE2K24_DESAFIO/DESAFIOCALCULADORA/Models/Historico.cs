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
            _historico.Add(operacao);
        }

        public List<string> HistoricoOperacoes
        {
            get { return _historico; }
        }

        public List<string> ObterTresUltimasOperacoes()
        {
            return _historico.Skip(Math.Max(0, _historico.Count - 3)).Take(3).ToList();
        }
    }
}

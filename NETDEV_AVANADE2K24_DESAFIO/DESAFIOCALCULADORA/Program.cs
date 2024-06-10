using System;
using System.Collections.Generic;
using DESAFIOCALCULADORA.Models;


        
            //Instância de Historico
            Historico historico = new Historico();

            //Instância de CalculadoraSimples, passando o historico
            CalculadoraSimples calculadora = new CalculadoraSimples(historico);

            calculadora.Somar(1, 1);
            calculadora.Somar(2, 2);
            calculadora.Somar(3, 5);
            calculadora.Somar(4, 5);

            // Obtenha o histórico de operações
            foreach (var operacao in historico.HistoricoOperacoes)
            {
                Console.WriteLine(operacao);
            }

            // Obtenha as últimas três operações do histórico
            Console.WriteLine("Últimas três operações:");
            foreach (var operacao in historico.ObterTresUltimasOperacoes())
            {
                Console.WriteLine(operacao);
            }
        
    


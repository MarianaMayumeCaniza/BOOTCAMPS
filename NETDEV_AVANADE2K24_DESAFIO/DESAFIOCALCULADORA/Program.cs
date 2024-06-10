using System;
using System.Collections.Generic;
using DESAFIOCALCULADORA.Models;


        
            //Instância de Historico
            Historico historico = new Historico();
              string data = "02/02/2020";

            //Instância de CalculadoraSimples, passando o historico
            CalculadoraSimples calculadora = new CalculadoraSimples(historico, data);

            calculadora.Somar(1, 1);
            calculadora.Somar(2, 2);
            calculadora.Somar(3, 5);
            calculadora.Somar(4, 5);

            
    


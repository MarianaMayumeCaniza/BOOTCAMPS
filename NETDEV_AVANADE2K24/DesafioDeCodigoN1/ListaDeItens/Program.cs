using System;
using System.Collections.Generic;

   
// Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        for (int item=0; item<3; item++)
        {
            itens.Add(Console.ReadLine());
           
        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    
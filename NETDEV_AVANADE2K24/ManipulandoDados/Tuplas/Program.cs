using System;
using  Leitura.Models;

(int, string,string)tupla = (1,"Mariana", "Caniza" );

Console.WriteLine($"Id:{tupla.Item1}");
Console.WriteLine($"Nome:{tupla.Item2}");
Console.WriteLine($"Sobrenome:{tupla.Item3}");


ValueTuple<int,string,string> outroExemplo = (1,"Mariana", "Caniza");
var outroExemploTupla = Tuple.Create(1,"Mariana","Caniza");


LeituraArquivo arquivo = new LeituraArquivo();


var(sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("ManipulandoDados/Arquivos/arquivoLeitura.txt");

if (sucesso){
    Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach(string linha in linhasArquivo){
        Console.WriteLine(linha);
    }}else{
        Console.WriteLine("Não foi possível ler o arquivo");
    }

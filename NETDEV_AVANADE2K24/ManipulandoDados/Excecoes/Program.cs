
using System.Linq.Expressions;
using Excecoes.Models;

try
{
    string[] linhas = File.ReadAllLines("ManipulandoDados/Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas){
        Console.WriteLine(linha);
    }
}catch(FileNotFoundException ex){
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}catch(DirectoryNotFoundException ex){
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho para a pasta não encontrado {ex.Message}");
}catch (Exception ex){
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}finally{
    Console.WriteLine("Fim das exceções");
}
    
new ExemploExcecao().Metodo1();

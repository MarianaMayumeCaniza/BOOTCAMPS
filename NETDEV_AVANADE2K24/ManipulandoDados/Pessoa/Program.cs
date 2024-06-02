using System;
using Pessoa.Models;
using Newtonsoft.Json;

DadosPessoa Mariana = new DadosPessoa(nome:"Mariana",sobrenome: "Caniza");

DadosPessoa João = new DadosPessoa();
João.Nome = "João";
João.Sobrenome = "Neves";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos= new List<DadosPessoa>();

cursoDeIngles.AdicionarAluno(Mariana);
cursoDeIngles.AdicionarAluno(João);
cursoDeIngles.ListarAluno();

string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;


(string nome, string sobrenome) = Mariana;



DateTime dataAtual = DateTime.Now;
Vendas v1 = new Vendas (1, "Material de escritório", 25.00M, dataAtual);
//string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
//File.WriteAllText("Pessoa/venda.json", serializado);
//Console.WriteLine(serializado);

List <Vendas> ListaVendas = new List<Vendas>();

Vendas v2 = new Vendas(2,"Licença de Software", 110.00M, dataAtual);

ListaVendas.Add(v1);
ListaVendas.Add(v2);
string serializado = JsonConvert.SerializeObject(ListaVendas, Formatting.Indented);
File.WriteAllText("Arquivos/venda.json", serializado);
Console.WriteLine(serializado);

string conteudoArquivo = File.ReadAllText("Arquivos/venda.json");
List<Vendas> listaDeVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);
foreach (Vendas venda in listaDeVenda){
    Console.WriteLine($"Id:{venda.Id}, Produto:{venda.Produto} "+
    $"Preço:{venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string,string> item in estados){
    Console.WriteLine($"Chave:{item.Key}, valor:{item.Value}");
}

estados.Remove("BA");

foreach(var item in estados){
     Console.WriteLine($"Chave:{item.Key}, valor:{item.Value}");
}

estados["SP"] = "São Paulo - valor alterado";
foreach(var item in estados){
     Console.WriteLine($"Chave:{item.Key}, valor:{item.Value}");
}


string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey("BA")){
    Console.WriteLine($"Valor existente: {chave}");

}else{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave:{chave}");
}
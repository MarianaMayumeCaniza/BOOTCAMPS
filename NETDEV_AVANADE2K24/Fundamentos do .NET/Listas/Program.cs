List<string> listaString = new List<string>();

listaString.Add("SP");	
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine("Percorrendo a lista com o FOR");
for (int contador = 0; contador < listaString.Count; contador++){
    Console.WriteLine($"Posição n° {contador} - {listaString[contador]}");
}

int contadorForeach = 0;
Console.WriteLine("Percorrendo a lista com FOREACH");
foreach(string caractere in listaString) {
    Console.WriteLine($"Posição n° {contadorForeach} - {listaString[contadorForeach]}");
    contadorForeach++;
}
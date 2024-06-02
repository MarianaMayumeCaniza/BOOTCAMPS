int [] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

int[] arrayInteirosDobro = new int[arrayInteiros.Length*2];
Array.Copy(arrayInteiros, arrayInteirosDobro,arrayInteiros.Length);

Array.Resize (ref arrayInteiros, arrayInteiros.Length*2);

for (int contador = 0; contador< arrayInteiros.Length; contador ++){
    Console.WriteLine($"Posição n° {contador} - {arrayInteiros[contador]}");
}



int contadorForEach = 0;
foreach(int variavel in arrayInteiros){
    Console.WriteLine($"Posição n°{contadorForEach} -{variavel}");
    contadorForEach++;
} 
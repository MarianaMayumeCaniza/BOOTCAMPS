using System.Data;

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoPesponsavel = false;

//Se ambos forem falsa não é liberado

if( ehMaiorDeIdade || possuiAutorizacaoDoPesponsavel){
    Console.WriteLine("Entrada liberada!");

}else{
    Console.WriteLine("Entrada não liberada");
}


bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media>=7){
    Console.WriteLine("Aprovado!");

}else{
    Console.WriteLine("Reprovado!");
}

bool choveu = true;
bool estaTarde = true;

if(choveu && estaTarde){
    Console.WriteLine("Vou pedalar");
}else{
    Console.WriteLine("Vou pedalar outro dia");
}
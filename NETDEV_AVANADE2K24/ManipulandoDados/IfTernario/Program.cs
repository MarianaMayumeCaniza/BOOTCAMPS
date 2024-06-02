int numero = 20;


bool ehPar = false;


if (numero % 2 ==0){
    Console.WriteLine($"O numero {numero} é par");

}else {
    Console.WriteLine($"O numero {numero} é impar");
}


ehPar = numero %2==0;

Console.WriteLine($"O numero {numero} é" +(ehPar? "par":"impar"));
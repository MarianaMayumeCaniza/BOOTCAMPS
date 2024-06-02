int numero = 10;

for (int contador = 0; contador <= numero; contador ++){
    Console.WriteLine($"{numero} x {contador} = {numero *contador}");
}


int numero2 = 10;
int contador2 = 0;

while(contador2<= 10){
    Console.WriteLine($"{contador2 +1}° Execução: { numero2} x {contador2} = {numero2 * contador2}");
    contador2 ++;

    if (contador2 == 10){
        break;
    }
}

int soma =0, numero3 = 0;

do{
    Console.WriteLine("Digite um numero (0 para parar)");
    numero3 = Convert.ToInt32(Console.ReadLine());

    soma += numero3;

}while(numero3 != 0);

Console.WriteLine($"Total da soma dos números digitados é : {soma}");

string opcao;
// while(true){
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();
//     switch(opcao){
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break ;
        
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
        
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;
        
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }



// }



bool exibirMenu = true;
while(exibirMenu){
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();
    switch(opcao){
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de cliente");
            break ;
        
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("Opção inválida");
            break;
    }



}
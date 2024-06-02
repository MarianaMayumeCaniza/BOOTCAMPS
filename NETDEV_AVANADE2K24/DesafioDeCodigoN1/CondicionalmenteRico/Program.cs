using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {

        int saldoTotal = int.Parse(Console.ReadLine());
        

        int valorSaque = int.Parse(Console.ReadLine());
        
        if (saldoTotal >= valorSaque){
            Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoTotal-valorSaque}");
        }else{
            Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
        }
    }
}
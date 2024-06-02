Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(8);
fila.Enqueue(16);

foreach (int item in fila) {
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (int item in fila) {
    Console.WriteLine(item);
}


Stack<int> pilha = new Stack<int>();

pilha.Push(2);  
pilha.Push(4);
pilha.Push(8);
pilha.Push(16);

foreach (int item in pilha) {
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo elemento do topo:{pilha.Pop()}");
foreach (int item in pilha) {
    Console.WriteLine(item);
}

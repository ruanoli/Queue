//Criando uma fila.
Queue<int> fila = new Queue<int>();

fila.Enqueue(2); //adc um item no final da fila.
fila.Enqueue(4); //adc um item no final da fila.
fila.Enqueue(6); //adc um item no final da fila.
fila.Enqueue(8); //adc um item no final da fila.


//Removendo um elemento da fila.
//OBS: Não podemos passar parâmetros para esse método
//pois ele sempre irá remover o item que entrou na fila primeiro.
fila.Dequeue();

//Percorrendo a fila para acessar os itens adicionados.
foreach (var item in fila)
{
    Console.WriteLine(item);
}
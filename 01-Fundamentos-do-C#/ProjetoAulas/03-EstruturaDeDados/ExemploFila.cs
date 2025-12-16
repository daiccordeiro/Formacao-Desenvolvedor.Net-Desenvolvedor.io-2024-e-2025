//Queue - Fila (FIFO) - Primeiro que entra é o Primeiro que sai
using System.Collections;

public static class ExemploFila
{
    public static void ExibirFila()
    {
        {
            var queue = new Queue<string>();
            queue.Enqueue("Daiane");    
            queue.Enqueue("Cordeiro");

        /*  foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        */

            //var nome = queue.Peek();
            //var nome1 = queue.Peek();

            //Enqueue = Empilhar | Dequeue = Desempilhar
            var nome = queue.Dequeue(); // Primeira execucao
            var nome1 = queue.Dequeue(); // Segunda execucao

            Console.WriteLine(nome);
            Console.WriteLine(nome1);
        }
    }
}
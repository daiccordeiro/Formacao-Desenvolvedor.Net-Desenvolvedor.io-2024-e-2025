//Stack - Fila (LIFO) - Último que entra é o Primeiro que sai
using System.Collections;

public static class ExemploPilha
{
    public static void ExibirPilha()
    {
        {
           var stack = new Stack<string>();
            stack.Push("Daiane");   //Primeiro
            stack.Push("Cordeiro"); //Último

        /*  foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        */
            var nome = stack.Pop();
            var nome1 = stack.Pop();
            Console.WriteLine(nome);
            Console.WriteLine(nome1);
        }
    }
}
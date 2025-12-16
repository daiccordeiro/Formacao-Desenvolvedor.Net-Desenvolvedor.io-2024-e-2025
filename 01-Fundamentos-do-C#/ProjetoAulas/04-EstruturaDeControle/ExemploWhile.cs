//Laço de Repetição - While e Do While
using System.Collections;

public static class ExemploWhile
{
    public static void ExibirWhile()
    {
        {   // Valida primeiro e assim executa
            var i = 0;
            while(i < 2)
            {
                Console.WriteLine("var i = " + i);               
                i++;
            }

            //Primeira executa e depois valida
            var j = 0;
            do 
            {
                Console.WriteLine("var j = " + j);
                j++;
            } while (j < 2);
        }
    }
}
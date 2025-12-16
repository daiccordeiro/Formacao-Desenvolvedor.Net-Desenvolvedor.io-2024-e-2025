//Laço de Repetição - Break e Continue
using System.Collections;

public static class ExemploBreakeContinue
{
    public static void ExibirBreakeContinue()
    {
        {
            var i = 0;
            while(i < 5)
            {

                if(i < 2)
                {
                    Console.WriteLine("Continuando...");
                    i++;
                    continue;
                }

                Console.WriteLine("var i = " + i);
                i++;

                if(i == 2)
                {
                    Console.WriteLine("Valor de i é igual a 2 (dois)");
                    break;
                }
            }
        }
    }
}
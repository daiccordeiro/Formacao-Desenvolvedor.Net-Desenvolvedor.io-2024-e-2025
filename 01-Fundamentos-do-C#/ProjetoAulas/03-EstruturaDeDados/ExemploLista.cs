//Lista Genérica 
using System.Collections;

public static class ExemploLista
{
    public static void ExibirLista()
    {
        {
            var lista = new List<string>(10)
            {
                "Daiane",
                "Cordeiro",
            };

        /* 
            lista.Add("Daiane");
            lista.Add("Cordeiro");
            lista.Add("Curso");
        */

            var nome = lista[0];
            Console.WriteLine(nome);
            
        // lista.RemoveAt(1);


            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
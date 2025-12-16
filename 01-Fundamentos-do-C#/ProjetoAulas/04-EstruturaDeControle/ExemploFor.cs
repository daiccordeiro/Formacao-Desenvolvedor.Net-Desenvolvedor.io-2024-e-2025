//Laço de Repetição - For
using System.Collections;

public static class ExemploFor
{
    public static void ExibirFor()
    {
        {
            var lista = new List<string>() { "Daiane", "Curso", "Csharp"};
            var count = lista.Count;

            for(var i=0; i < count; i++)
            {
                var nome = lista[i];
                Console.WriteLine(nome);
            }
        }
    }
}
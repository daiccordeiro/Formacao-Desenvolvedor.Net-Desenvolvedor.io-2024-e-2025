//ForEach
using System.Collections;

public static class ExemploForEach
{
    public static void ExibirForEach()
    {
        {
           var lista = new List<string>() { "Daiane", "Curso", "Csharp"};
            
        /*    foreach(string item in lista)
            {
                Console.WriteLine(item);
            }
        */    
            
            foreach(var letra in "Daiane Cordeiro")
            {
                Console.WriteLine(letra);
            }
        }
    }
}
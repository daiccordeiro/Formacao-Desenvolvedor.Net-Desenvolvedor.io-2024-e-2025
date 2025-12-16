//Lista Genérica 
using System.Collections;

public static class ExemploDicionario
{
    public static void ExibirDicionario()
    {
        {
            var dicionario = new Dictionary<string, string>() //recebe dois parâmetros: chave e valor
            {
                {"teste", "Teste"},
                {"teste6", "Teste 6"},
            };

            dicionario.Add("nome", "Daiane");

            dicionario["curso"] = "Curso";

            var nome = dicionario["curso"];
            //Console.WriteLine(nome);

            foreach(var item in dicionario)
            {   
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
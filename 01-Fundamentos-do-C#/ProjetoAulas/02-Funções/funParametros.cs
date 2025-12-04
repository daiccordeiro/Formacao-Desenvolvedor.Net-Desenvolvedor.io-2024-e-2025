//Criando Função que recebe Parâmetros
public static class FunParametros
{
    public static void ExibirFuncaoParametros()
    { 
    var soma = SomaValores(3,5);
    Console.WriteLine(soma);

    var nome = NomeEIdade("Daiane", 36);
    Console.WriteLine(nome);

    int SomaValores(int a, int b)
        {
            return a + b;
        }

    string NomeEIdade(string nome, int idade)
        {
            return "Meu nome é " + nome + " e tenho " + idade + " anos";
        }
    }
}
//Escrendo minha Primeira Função 
public static class FunNomeCompleto
{
    public static void ExibirFuncaoNomeCompleto()
    {        
        EscreverNome();
        
        void EscreverNome()
        {
           var nome = NomeCompleto();
            var soma = SomaValores();

            Console.WriteLine(nome);
            Console.WriteLine(soma); 
        }

        string NomeCompleto()
        {
            string primeiroNome = "Daiane";
            string segundoNome = "Cordeiro";

            return primeiroNome + " " + segundoNome;
        }

        int SomaValores()
        {
            return 8 + 2;
        }
    }
}       
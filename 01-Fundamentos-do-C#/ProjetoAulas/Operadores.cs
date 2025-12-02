// Operações Aritméticas
public static class Operadores
{
    public static void ExibirOperadores()
    {
        int numero1 = 1;
        var numero2 = 2;

        int soma = numero1 + numero2;
        Console.WriteLine(soma);

        int subtracao = numero2 - numero1;
        Console.WriteLine(subtracao);

        int multiplicacao = (numero1 * numero2) * 10;
        Console.WriteLine(multiplicacao);

        int divisao = numero2 / numero1;
        Console.WriteLine(divisao);
    }
}
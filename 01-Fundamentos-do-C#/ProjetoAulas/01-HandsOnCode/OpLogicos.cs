//Definindo Constantes
public static class OpLogicos
{
    public static void ExibirOpLogicos()
    {        
        int numero1 = 1;
        var numero2 = 2;

        //&& = E
        bool valido = numero2 > numero1 && 6 > 7;
        Console.WriteLine(valido);

        // || = OU
        bool valido2 = numero2 > 10 || 6 > 7;
        Console.WriteLine(valido2);

        // '! = NOT
        bool valido3 = !(numero2 > 3);
        Console.WriteLine(valido3);
    }
}       
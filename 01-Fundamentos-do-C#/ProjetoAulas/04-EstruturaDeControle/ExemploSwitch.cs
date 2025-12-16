//Stack - Fila (LIFO) - Último que entra é o Primeiro que sai
using System.Collections;

public static class ExemploSwitch
{
    public static void ExibirSwitch()
    {
        {
            var diaDaSemana = 5;
            switch(diaDaSemana)
            {
                case 0:
                {
                    Console.WriteLine("Hoje é Domingo");
                    break;
                }
                case 1:
                    Console.WriteLine("Hoje é Segunda-Feira");
                    break;
                case 2:
                    Console.WriteLine("Hoje é Terça-Feira");
                    break;
                case 3:
                    Console.WriteLine("Hoje é Quarta-Feira");
                    break;
                case 4:
                    Console.WriteLine("Hoje é Quinta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Hoje é Sexta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Hoje é Sábado");
                    break;   
                default:      
                    Console.WriteLine("Dia da Semana Inválido");      
                    break;
            }
            
        // Para tratar mais de uma condição, usamos o If
        /*  var diaDaSemana = 0;
            if(diaDaSemana < 1)
            {
                Console.WriteLine("Hoje é Domingo");
            }
            else
            {
                Console.WriteLine("Dia da Semana Inválido");      
            }
        */
        }
    }
}
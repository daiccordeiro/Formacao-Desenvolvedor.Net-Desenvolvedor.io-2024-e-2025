//Stack - Fila (LIFO) - Último que entra é o Primeiro que sai
using System.Collections;

public static class ExemploIFeElse
{
    public static void ExibirIFeElse()
    {
        {
        /* // Primeiro exemplo
            var diaDaSemana = 0;
            var diaDeTrabalho = false;

            if(diaDaSemana == 0 && diaDeTrabalho == true)
            {
                Console.WriteLine("Hoje é domingo");
            }
            else if(diaDaSemana == 0 && diaDeTrabalho == false)
            {
                Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
            }
            else
            {
                Console.WriteLine("Hoje não é domingo");
            }
        */

            var diaDaSemana = 2;
            if(diaDaSemana == 0)
            {
                Console.WriteLine("Hoje é Domingo");
            }
            else if(diaDaSemana == 1)
            {
                Console.WriteLine("Hoje é Segunda-Feira");
            }
            else if(diaDaSemana == 2)
            {
                Console.WriteLine("Hoje é Terça-Feira");
            }
            else if(diaDaSemana == 3)
            {
                Console.WriteLine("Hoje é Quarta-Feira");
            }
            else if(diaDaSemana == 4)
            {
                Console.WriteLine("Hoje é Quinta-Feira");
            }
            else if(diaDaSemana == 5)
            {
                Console.WriteLine("Hoje é Sexta-Feira");
            }
            else if(diaDaSemana == 6)
            {
                Console.WriteLine("Hoje é Sábado");
            }
            else
            {
                Console.WriteLine("Dia da Semana Inválido");
            }       
        }
    }
}
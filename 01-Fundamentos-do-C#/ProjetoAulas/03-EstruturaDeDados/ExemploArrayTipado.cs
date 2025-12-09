//ArrayTipado 
using System.Collections;

public static class ExemploArrayTipado
{
    public static void ExibirArrayTipado()
    {
        {                                       //0  1  2 
            //var arrayTipadoNumero = new int[3] {1, 2, 3}; //arrayTipado que só aceita números
            
            var arrayTipadoNumero = new int[3];
            arrayTipadoNumero[0] = 3;
            arrayTipadoNumero[1] = 5;
            arrayTipadoNumero[2] = 10;

            //Array.Resize(ref arrayTipadoNumero, 100);
            //arrayTipadoNumero[10] = 100;

            foreach(var item in arrayTipadoNumero)
            {
                Console.WriteLine(item);
            }

            //var arrayTipadoString = new string[2] {"Daiane", "Cordeiro"};
            
            var arrayTipadoString = new string[2];
            arrayTipadoString[0] = "Daiane";
            arrayTipadoString[1] = "Cordeiro";
            
            foreach(var item in arrayTipadoString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
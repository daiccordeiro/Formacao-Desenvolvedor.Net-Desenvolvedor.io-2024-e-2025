//ArrayList 
using System.Collections;

public static class ExemploArrayList
{
    public static void ExibirArrayList()
    {
        {
            var arrayList = new ArrayList();
            arrayList.Add(1);           // 0
            arrayList.Add("Daiane");    // 1    
            arrayList.Add(true);        // 2
            Console.WriteLine(arrayList[1]); // acesso por indice

            arrayList.RemoveAt(1);      // Para remover de um array
            arrayList.Clear();          // Para limpar o array

            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
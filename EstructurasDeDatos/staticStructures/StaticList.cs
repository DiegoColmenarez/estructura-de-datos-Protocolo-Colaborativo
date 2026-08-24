namespace EstructurasDeDatos.staticStructures;

public class StaticList
{
    private int[] arrayNums;
    public StaticList(int[] arrayNums)
    {
        this.arrayNums = arrayNums;
    }

    public static void PrintArray(int[] arrayNums)
    {
        Console.WriteLine("Numeros en el arreglo:");
        for (int i = 0; i < arrayNums.Length; i++)
        {
            Console.WriteLine("[indice: " + i + " Valor: " + arrayNums[i] + "]");
        }
    }
    
}
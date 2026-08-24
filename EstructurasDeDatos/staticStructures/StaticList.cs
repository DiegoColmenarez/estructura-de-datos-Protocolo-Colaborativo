
namespace EstructurasDeDatos.staticStructures;

public class StaticList()
{
    public static void PrintArray(int[] arrayNums)
    {
        Console.WriteLine("Numeros en el arreglo:");
        for (int i = 0; i < arrayNums.Length; i++)
        {
            Console.WriteLine("[indice: " + i + " Valor: " + arrayNums[i] + "]");
        }
    }

    private static int[] TransformArray(int[] arrayNums, Func<int, int, int> operation)
    {
        var resultArray = new int[arrayNums.Length];
        for (var i = 0; i < arrayNums.Length; i++)
        {
            resultArray[i] = operation(arrayNums[i], i);
        }

        return resultArray;
    }

    public static int[] MultiplyArrayByIndex(int[] arrayNums)
    {
        return TransformArray(arrayNums, (value, index) => index * value);
    }

    public static int[] ChangeOddNums(int[] arrayNums)
    {
        return TransformArray(arrayNums, (value, index) => value % 2 == 0 ? value : 0);
    }
}
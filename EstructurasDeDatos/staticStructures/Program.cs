namespace EstructurasDeDatos.staticStructures;

internal static class Program
{
    public static void Main(string[] args)
    {
        var arrayInt = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        StaticList.PrintArray(arrayInt);

        var arrayByIndex = StaticList.MultiplyArrayByIndex(arrayInt);
        StaticList.PrintArray(arrayByIndex);
        
        var arrayOdds = StaticList.ChangeOddNums(arrayInt);
        StaticList.PrintArray(arrayOdds);
    }
}
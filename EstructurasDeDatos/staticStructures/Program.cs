using EstructurasDeDatos.dinamicStructures;

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
        Console.WriteLine("");

        var matrix = new int[,] { { 1,2,3 }, { 4,5,6 }, {7,8,9} };
        
        Matrix.PrintMatrix(matrix);
        Console.WriteLine("");
        Matrix.PrintByColumn(matrix);
        Console.WriteLine("");
        
        var matrix2 = Matrix.FlipHorizontalMatrix(matrix);
        Matrix.PrintMatrix(matrix2);
        Console.WriteLine("");
        
        Console.WriteLine(Matrix.SumAllValues(matrix));

        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var list2 = DinamicList.ChangeOddNumsList(list);
        var list3 = DinamicList.MultiplyByIndexList(list);
        DinamicList.PrintList(list);
        DinamicList.PrintList(list2);
        DinamicList.PrintList(list3);
    }
}
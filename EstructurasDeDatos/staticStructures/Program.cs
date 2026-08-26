using EstructurasDeDatos.dinamicStructures;
using EstructurasDeDatos.exercise7;

namespace EstructurasDeDatos.staticStructures;

internal static class Program
{
    public static void Main(string[] args)
    {
        /*
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
         DinamicList.PrintList(list3); */

        var calculator = new Calculator();
        var produdts = new List<Product>()
        {
            new Product("A001", "Teclado Mecanico", 500 * 100),
            new Product("A002", "Laptop", 1000 * 100),
            new Product("A003", "Motorola One Fusion", 600 * 100),
        };
        var salesLines = new List<SalesLine>()
        {
            new SalesLine(produdts[0], 7),
            new SalesLine(produdts[1], 9),
            new SalesLine(produdts[2], 9),
        };
        var bestSellers = calculator.GetBestSelling(salesLines);
        
        Console.WriteLine(calculator.GetTotal(salesLines)/100);
        Console.WriteLine("productos o producto más vendido: \n" + bestSellers[0].Name + "\n"+ bestSellers[1].Name);
        
    }
}
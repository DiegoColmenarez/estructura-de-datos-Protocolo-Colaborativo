namespace EstructurasDeDatos.dinamicStructures;

public class DinamicList
{
    private static List<int> TransformList(List<int> integerList, Func<int, int, int> operation)
    {
        var result = new List<int>(integerList.Count);
        for (var i = 0; i < integerList.Count; i++)
        {
            result.Add(operation(integerList[i], i));
        }
        return result;
    }
    
    public static List<int> ChangeOddNumsList(List<int> integerList)
    {
        return TransformList(integerList, (num, index) => num % 2 == 0 ? num : 0);
    }
    
    public static List<int> MultiplyByIndexList(List<int> integerList)
    {
        return TransformList(integerList, (num, index) => num * index);
    }
}
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
}
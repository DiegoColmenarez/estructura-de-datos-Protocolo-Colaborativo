namespace EstructurasDeDatos.exercise7;

public class Calculator : IGetBestSelling, IGetTotal
{
    public List<Product> GetBestSelling(List<SalesLine> salesLineList)
    {
        var result = new List<Product>();
       /* var maxSales = -1;
    
        foreach (var line in salesLineList)
        {
            if (line.SalesNum > maxSales)
            {
                maxSales = line.SalesNum;
                result.Clear();
                result.Add(line.Product);
            }
            else if (line.SalesNum == maxSales)
            {
                result.Add(line.Product);
            }
        } */
    
        return result;
    }

    public long GetTotal(List<SalesLine> salesLineList)
    {
        return salesLineList.Sum(line => line.LineTotal);
    }
}
namespace EstructurasDeDatos.exercise7;

public class Calculator : IGetBestSelling, IGetTotal
{
    public List<Product> GetBestSelling(List<SalesLine> salesLineList)
    {
        throw new NotImplementedException();
    }

    public long GetTotal(List<SalesLine> salesLineList)
    {
        return salesLineList.Sum(line => line.LineTotal);
    }
}
namespace EstructurasDeDatos.exercise7;

public class SalesLine(Product product, int salesNum)
{
    private Product Product { get; } = product; 
    private int SalesNum { get; } = salesNum;

    public long LineTotal => Product.PriceInCent * SalesNum;
}
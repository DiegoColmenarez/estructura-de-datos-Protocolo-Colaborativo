namespace EstructurasDeDatos.exercise7;

public class SalesLine(Product product, int salesNum)
{
    public Product Product { get; } = product; 
    public int SalesNum { get; } = salesNum;

    public long LineTotal => Product.PriceInCent * SalesNum;
}